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

result = ''

for row in GetPoceduresFromConnection():
	procedure = CleanPocedure(row)

	preFunctionComment = '\n// {0} \n// SQL ({1}...)\n'.format(procedure['Title'], procedure['SQL'])
	# preFunctionComment = '\n// {0} \n'.format(procedure['Title'])

	funcTitle = procedure['Title'].replace('sp_', '')[0].upper() + procedure['Title'].replace('sp_', '')[1:]
	functionTitleCSharp = 'public static void {0} ('.format(funcTitle)
	if len(procedure['Params']) > 0:
		functionTitleCSharp += procedure['Params'][0]['CShType'] + '? '
		functionTitleCSharp += procedure['Params'][0]['name']
		for i in procedure['Params'][1:]:
			functionTitleCSharp += ', ' + i['CShType'] + '? '
			functionTitleCSharp += i['name']
	functionTitleCSharp += ')\n'
	
	functionBodyCSharp = '{'
	functionBodyCSharp += '\n\tusing (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))\n\t{'
	functionBodyCSharp += '\n\t\ttry\n\t\t{'
	functionBodyCSharp += '\n\t\t\t_db.Database.ExecuteSqlCommand('
	functionBodyCSharp += '\n\t\t\t\t"EXEC [dbo].[{0}]'.format(procedure['Title'])

	if len(procedure['Params']) > 0:
		functionBodyCSharp += ' @' + procedure['Params'][0]['Name']
		for i in procedure['Params'][1:]: functionBodyCSharp += ', @' + i['Name']

	functionBodyCSharp += ';"'

	if len(procedure['Params']) > 0:
		functionBodyCSharp += ','
		functionBodyCSharp += '\n\t\t\t\tnew[]\n\t\t\t\t{'
		for i in procedure['Params']:
			functionBodyCSharp += '\n\t\t\t\t\tnew SqlParameter("'+str('@' + i['Name'])+'", System.Data.SqlDbType.'+i['DBType']+') { Value = (object)'+i['name']+' ?? DBNull.Value},'
		functionBodyCSharp += '\n\t\t\t\t}'

	functionBodyCSharp += '\n\t\t\t);'
	functionBodyCSharp += '\n\t\t} catch (Exception ex) { MessageBox.Show(ex.Message); }'
	functionBodyCSharp += '\n\t}'
	functionBodyCSharp += '\n}'
	
	result += preFunctionComment 
	result += functionTitleCSharp 
	result += functionBodyCSharp 


	funcTitle = procedure['Title'].replace('sp_', '')[0].upper() + procedure['Title'].replace('sp_', '')[1:]
	functionTitleCSharp = 'public static void {0} ('.format(funcTitle)
	if len(procedure['Params']) > 0:
		functionTitleCSharp += 'object '
		functionTitleCSharp += procedure['Params'][0]['name']
		for i in procedure['Params'][1:]:
			functionTitleCSharp += ', object '
			functionTitleCSharp += i['name']
	functionTitleCSharp += ')\n'
	
	result += preFunctionComment 
	result += functionTitleCSharp 
	result += functionBodyCSharp 

	result += '\n\n' 

codecs.open('{0}.cs'.format('StoredProcedures'), 'w', 'utf-8').write(result)