import json
import codecs
import os
import pyodbc
import re 

types = [
	{'SQL':'bigint', 'CSh':'Guid', 'DBType':'BigInt'},
	{'SQL':'binary', 'CSh':'byte[]', 'DBType':'VarBinary'},
	{'SQL':'bit', 'CSh':'bool', 'DBType':'Bit'},
	{'SQL':'char','CSh':'string','DBType':'Char'},
	{'SQL':'date','CSh':'DateTime','DBType':'Date'},
	{'SQL':'datetime','CSh':'DateTime','DBType':'DateTime'},
	{'SQL':'datetime2','CSh':'DateTime','DBType':'DateTime2'},
	{'SQL':'datetimeoffset','CSh':'DateTimeOffset','DBType':'DateTimeOffset'},
	{'SQL':'decimal','CSh':'decimal','DBType':'Decimal'},
	{'SQL':'FILESTREAM','CSh':'byte[]','DBType':'VarBinary'},
	{'SQL':'float','CSh':'double','DBType':'Float'},
	{'SQL':'image','CSh':'Byte[]','DBType':'Binary'},
	{'SQL':'int','CSh':'int','DBType':'Int'},
	{'SQL':'integer','CSh':'int','DBType':'Int'},
	{'SQL':'money','CSh':'decimal','DBType':'Money'},
	{'SQL':'nchar','CSh':'string','DBType':'Money'},
	{'SQL':'ntext','CSh':'string','DBType':'NText'},
	{'SQL':'numeric','CSh':'decimal','DBType':'Decimal'},
	{'SQL':'nvarchar','CSh':'string','DBType':'NVarChar'},
	{'SQL':'real','CSh':'Single','DBType':'Real'},
	{'SQL':'rowversion','CSh':'byte[]','DBType':'Timestamp'},
	{'SQL':'smalldatetime','CSh':'DateTime','DBType':'DateTime'},
	{'SQL':'smallint','CSh':'Int16','DBType':'SmallInt'},
	{'SQL':'smallmoney','CSh':'decimal','DBType':'SmallMoney'},
	{'SQL':'sql_variant','CSh':'object','DBType':'Variant'},
	{'SQL':'text','CSh':'string','DBType':'Text'},
	{'SQL':'time','CSh':'TimeSpan','DBType':'Time'},
	{'SQL':'timestamp','CSh':'byte[]','DBType':'Timestamp'},
	{'SQL':'tinyint','CSh':'byte','DBType':'TinyInt'},
	{'SQL':'uniqueidentifier','CSh':'Guid','DBType':'UniqueIdentifier'},
	{'SQL':'varbinary','CSh':'string','DBType':'VarChar'},
	{'SQL':'xml','CSh':'Xml','DBType':'Xml'},
	{'SQL':'sysname','CSh':'string','DBType':'NVarChar'}
]


def CShConverter(sqlType):
	for t in types:
		if t['SQL'].lower() == sqlType.lower(): return t['CSh']

	return 'object'

def DBTypeConverter(sqlType):
	for t in types:
		if t['SQL'].lower() == sqlType.lower(): return t['DBType']

	return 'object'

def GetPoceduresFromConnection():
	with codecs.open('connection.json', 'r', 'utf-8') as read_file:
		data = json.load(read_file)

		connectionstr = 'DRIVER={0};SERVER={1};DATABASE={2};UID={3};PWD={4}'.format(
			"{SQL Server\}",
			str(data['SERVER']), # SERVER, 
			str(data['DATABASE']), # DATABASE, 
			str(data['User']), # User, 
			str(data['Password'])) # Password
		
		print(connectionstr)

	cnxn = pyodbc.connect(connectionstr) # Подключение
	cursor = cnxn.cursor()

	cursor.execute(open('SelectSP.sql').read())
	return cursor.fetchall()

def CleanPocedure(prasedure):

	Body = prasedure[1]
	
	Body = str(re.search(r'(?i)(CREATE\W*PROCEDURE){1}([\D\d]*?(\WAS){1}){,1}', Body).group(0))

	for i in re.findall(r'(?i)--.*\n', str(Body)):
		Body = Body.replace(i, '')
	
	for i in re.findall(r'(?i)\s+', str(Body)):
		Body = Body.replace(i, ' ')

	Body = Body.replace('\n', '').replace('\t', '')

	params = list()
	for i in re.findall(r'(?i)@\w*\s*\w*', str(Body)):
		param = list()
		for p in i.split(' '):
			if p != None and p != '' and p != ' ': param.append(p)
		params.append(
			{ 
				'Name':param[0].replace('@', ''),
				'name': '_'+param[0].replace('@', '')[0].lower() + param[0].replace('@', '')[1:],
				'Type':param[1].upper(),
				'DBType':DBTypeConverter(param[1]),
				'CShType': CShConverter(param[1])
			}
		)

	return {
		'Title':prasedure[0],
		'SQL':Body,
		'Params':params,
		'DateChanged':prasedure[2]
	}

with codecs.open('temp_sp.cs', 'r', 'utf-8') as read_file:
	temp = read_file.read()
result = ''

for row in GetPoceduresFromConnection():
	procedure = CleanPocedure(row)

	_SP_NAME = procedure['Title'] # @_SP_NAME - наименование из бд
	
	_SP_CREATE_SQL = procedure['SQL'] # @_SP_CREATE_SQL - шапка SQL запроса на создание функции
	
	_SP_TITLE = procedure['Title'].replace('sp_', '')[0].upper() + procedure['Title'].replace('sp_', '')[1:] # @_SP_TITLE - Ноименование для программы
	
	_SP_SQL = 'EXEC [dbo].[{0}]'.format(_SP_NAME) # @_SP_SQL - Запрос вызова хранимой процедуры
	if len(procedure['Params']) > 0:
		_SP_SQL += ' @' + procedure['Params'][0]['Name']
		for i in procedure['Params'][1:]: _SP_SQL += ', @' + i['Name']
	_SP_SQL += ';'

	if len(procedure['Params']) > 0:
		_SP_PARAMS_LIST_OBJECT = 'object ' + procedure['Params'][0]['name'] # @_SP_PARAMS_LIST_OBJECT - Список инициализируемых параметров с не четкой типизацией
		for i in procedure['Params'][1:]: _SP_PARAMS_LIST_OBJECT += ', object ' + i['name']

	if len(procedure['Params']) > 0:
		_SP_PARAM_LIST_SQL = '' # @_SP_PARAM_LIST_SQL - Список параметров для SqlParameter[]
		for i in procedure['Params']:
			_SP_PARAM_LIST_SQL += 'new SqlParameter("'+str('@' + i['Name'])+'", System.Data.SqlDbType.'+i['DBType']+') { Value = (object)'+i['name']+' ?? DBNull.Value},'
		_SP_PARAM_LIST_SQL += ''

	if len(procedure['Params']) > 0:
		_SP_PARAMS_LIST = procedure['Params'][0]['CShType'] + '? ' + procedure['Params'][0]['name']  # @_SP_PARAMS_LIST - Список инициализируемых параметров с четкой типизацией
		for i in procedure['Params'][1:]: _SP_PARAMS_LIST += ', ' + i['CShType'] + '? ' + i['name']

	if len(procedure['Params']) > 0:
		_SP_PARAMS_NAMES_LIST = procedure['Params'][0]['name'] # @_SP_PARAMS_NAMES_LIST - Список наименований параметров
		for i in procedure['Params'][1:]: _SP_PARAMS_NAMES_LIST += ', ' + i['name']

	# print ('_SP_PARAMS_LIST_OBJECT ->',_SP_PARAMS_LIST_OBJECT)
	# print ('_SP_PARAMS_NAMES_LIST ->',_SP_PARAMS_NAMES_LIST)
	# print ('_SP_PARAM_LIST_SQL ->',_SP_PARAM_LIST_SQL)
	# print ('_SP_PARAMS_LIST ->',_SP_PARAMS_LIST)
	# print ('_SP_CREATE_SQL ->',_SP_CREATE_SQL)
	# print ('_SP_TITLE ->',_SP_TITLE)
	# print ('_SP_NAME ->',_SP_NAME)
	# print ('_SP_SQL ->',_SP_SQL)

	r = '\n' + temp
	r = r.replace('@_SP_PARAMS_LIST_OBJECT',_SP_PARAMS_LIST_OBJECT)
	r = r.replace('@_SP_PARAMS_NAMES_LIST',_SP_PARAMS_NAMES_LIST)
	r = r.replace('@_SP_PARAM_LIST_SQL',_SP_PARAM_LIST_SQL)
	r = r.replace('@_SP_PARAMS_LIST',_SP_PARAMS_LIST)
	r = r.replace('@_SP_CREATE_SQL',_SP_CREATE_SQL.replace('@','\n\t\t@'))
	r = r.replace('@_SP_TITLE',_SP_TITLE)
	r = r.replace('@_SP_NAME',_SP_NAME)
	r = r.replace('@_SP_SQL',_SP_SQL)

	result += r.replace(str(re.search(r'(/[*])[\s\S]*?(PARAM LIST:)[\s\S]*?([*]/)', r).group(0)), '')

codecs.open('{0}.cs'.format('StoredProcedures'), 'w', 'utf-8').write(result)