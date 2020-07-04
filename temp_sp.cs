/*	PARAM LIST:
	@_SP_NAME - наименование из бд
	@_SP_CREATE_SQL - шапка SQL запроса на создание функции
	@_SP_TITLE - Наименование для программы
	@_SP_SQL - Запрос вызова хранимой процедуры
	@_SP_PARAMS_LIST_OBJECT - Список инициализируемых параметров с не четкой типизацией
	@_SP_PARAM_LIST_SQL - Список параметров для SqlParameter[]
	@_SP_PARAMS_LIST - Список инициализируемых параметров с четкой типизацией
	@_SP_PARAMS_NAMES_LIST - Список наименований параметров
*/
#region @_SP_NAME

/* Наименование хранимой процедуры в БД: [dbo].[@_SP_NAME] 
   SQL (@_SP_CREATE_SQL) 
*/

// SQL запрос вызова [dbo].[@_SP_NAME] 
private static string @_SP_TITLE_SQL() =>
	"@_SP_SQL";

// Параметры SQL запрос вызова [dbo].[@_SP_NAME] 
private static SqlParameter[] @_SP_TITLE_Params(@_SP_PARAMS_LIST_OBJECT) => 
	new[] { @_SP_PARAM_LIST_SQL };

/// <summary>
/// Метод исполнения процедуры "[dbo].[@_SP_NAME]" с параметрами четкой типизации
/// </summary>
/// <param name="_entities">Подключение к бд</param>
public static void @_SP_TITLE(@_SP_PARAMS_LIST, Entities _entities = null) => 
	@_SP_TITLE(@_SP_PARAMS_NAMES_LIST, _entities);
	
/// <summary>
/// Метод исполнения процедуры "[dbo].[@_SP_NAME]" с параметрами не четкой типизации
/// </summary>
/// <param name="_entities">Подключение к бд</param>
public static void @_SP_TITLE(@_SP_PARAMS_LIST_OBJECT, Entities _entities = null)
{
	try
	{
		// было ли переданно уже созданное подулючение
		if (_entities == null)
			// Обработка с новым подключением
			using (Entities _db = new Entities(DbConnectionString.GZEntity.ConnectionString))
			{
				_db.Database.ExecuteSqlCommand(@_SP_TITLE_SQL(), @_SP_TITLE_Params(@_SP_PARAMS_NAMES_LIST));
			}
		else
			// Обработка с переданным подключением 
			_entities.Database.ExecuteSqlCommand(@_SP_TITLE_SQL(), @_SP_TITLE_Params(@_SP_PARAMS_NAMES_LIST)); 
	}
	catch (Exception ex) { MessageBox.Show($"Проблема исполнения процедуры \"[dbo].[@_SP_NAME]\": \n{ex.Message}"); }
}

#endregion