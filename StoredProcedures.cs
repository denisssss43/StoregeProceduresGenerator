
// sp_PricingGlobalSettingsEdit 
// SQL (CREATE PROCEDURE PricingGlobalSettingsEdit @LowerInterestRateLimit NUMERIC(15,2), @RelevancePriceDays INT, @UserGuid uniqueidentifier AS...)
public static void PricingGlobalSettingsEdit (decimal? _lowerInterestRateLimit, int? _relevancePriceDays, Guid? _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingGlobalSettingsEdit] @LowerInterestRateLimit, @RelevancePriceDays, @UserGuid;",
				new[]
				{
					new SqlParameter("@LowerInterestRateLimit", System.Data.SqlDbType.Decimal) { Value = (object)_lowerInterestRateLimit ?? DBNull.Value},
					new SqlParameter("@RelevancePriceDays", System.Data.SqlDbType.Int) { Value = (object)_relevancePriceDays ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingGlobalSettingsEdit 
// SQL (CREATE PROCEDURE PricingGlobalSettingsEdit @LowerInterestRateLimit NUMERIC(15,2), @RelevancePriceDays INT, @UserGuid uniqueidentifier AS...)
public static void PricingGlobalSettingsEdit (object _lowerInterestRateLimit, object _relevancePriceDays, object _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingGlobalSettingsEdit] @LowerInterestRateLimit, @RelevancePriceDays, @UserGuid;",
				new[]
				{
					new SqlParameter("@LowerInterestRateLimit", System.Data.SqlDbType.Decimal) { Value = (object)_lowerInterestRateLimit ?? DBNull.Value},
					new SqlParameter("@RelevancePriceDays", System.Data.SqlDbType.Int) { Value = (object)_relevancePriceDays ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRangesEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRangesEditOrCreated] @ProductCategoryGuid uniqueidentifier, @MinTo NUMERIC(15,2), @MiddleMinTo NUMERIC(15,2), @MiddleTo NUMERIC(15,2), @MiddleMaxTo NUMERIC(15,2),  @UserGuid uniqueidentifier AS...)
public static void PricingRangesEditOrCreated (Guid? _productCategoryGuid, decimal? _minTo, decimal? _middleMinTo, decimal? _middleTo, decimal? _middleMaxTo, Guid? _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRangesEditOrCreated] @ProductCategoryGuid, @MinTo, @MiddleMinTo, @MiddleTo, @MiddleMaxTo, @UserGuid;",
				new[]
				{
					new SqlParameter("@ProductCategoryGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productCategoryGuid ?? DBNull.Value},
					new SqlParameter("@MinTo", System.Data.SqlDbType.Decimal) { Value = (object)_minTo ?? DBNull.Value},
					new SqlParameter("@MiddleMinTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleMinTo ?? DBNull.Value},
					new SqlParameter("@MiddleTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleTo ?? DBNull.Value},
					new SqlParameter("@MiddleMaxTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleMaxTo ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRangesEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRangesEditOrCreated] @ProductCategoryGuid uniqueidentifier, @MinTo NUMERIC(15,2), @MiddleMinTo NUMERIC(15,2), @MiddleTo NUMERIC(15,2), @MiddleMaxTo NUMERIC(15,2),  @UserGuid uniqueidentifier AS...)
public static void PricingRangesEditOrCreated (object _productCategoryGuid, object _minTo, object _middleMinTo, object _middleTo, object _middleMaxTo, object _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRangesEditOrCreated] @ProductCategoryGuid, @MinTo, @MiddleMinTo, @MiddleTo, @MiddleMaxTo, @UserGuid;",
				new[]
				{
					new SqlParameter("@ProductCategoryGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productCategoryGuid ?? DBNull.Value},
					new SqlParameter("@MinTo", System.Data.SqlDbType.Decimal) { Value = (object)_minTo ?? DBNull.Value},
					new SqlParameter("@MiddleMinTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleMinTo ?? DBNull.Value},
					new SqlParameter("@MiddleTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleTo ?? DBNull.Value},
					new SqlParameter("@MiddleMaxTo", System.Data.SqlDbType.Decimal) { Value = (object)_middleMaxTo ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRetailSettingsEdit 
// SQL (CREATE PROCEDURE PricingRetailSettingsEdit @PriceAdvantagePercent NUMERIC(15,2), @PriceAdvantageRuble NUMERIC(15,2), @BasePriceGuid uniqueidentifier, @RevaluationBalances bit,  @RetailGuid uniqueidentifier, @UserGuid uniqueidentifier AS...)
public static void PricingRetailSettingsEdit (decimal? _priceAdvantagePercent, decimal? _priceAdvantageRuble, Guid? _basePriceGuid, bool? _revaluationBalances, Guid? _retailGuid, Guid? _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRetailSettingsEdit] @PriceAdvantagePercent, @PriceAdvantageRuble, @BasePriceGuid, @RevaluationBalances, @RetailGuid, @UserGuid;",
				new[]
				{
					new SqlParameter("@PriceAdvantagePercent", System.Data.SqlDbType.Decimal) { Value = (object)_priceAdvantagePercent ?? DBNull.Value},
					new SqlParameter("@PriceAdvantageRuble", System.Data.SqlDbType.Decimal) { Value = (object)_priceAdvantageRuble ?? DBNull.Value},
					new SqlParameter("@BasePriceGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_basePriceGuid ?? DBNull.Value},
					new SqlParameter("@RevaluationBalances", System.Data.SqlDbType.Bit) { Value = (object)_revaluationBalances ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRetailSettingsEdit 
// SQL (CREATE PROCEDURE PricingRetailSettingsEdit @PriceAdvantagePercent NUMERIC(15,2), @PriceAdvantageRuble NUMERIC(15,2), @BasePriceGuid uniqueidentifier, @RevaluationBalances bit,  @RetailGuid uniqueidentifier, @UserGuid uniqueidentifier AS...)
public static void PricingRetailSettingsEdit (object _priceAdvantagePercent, object _priceAdvantageRuble, object _basePriceGuid, object _revaluationBalances, object _retailGuid, object _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRetailSettingsEdit] @PriceAdvantagePercent, @PriceAdvantageRuble, @BasePriceGuid, @RevaluationBalances, @RetailGuid, @UserGuid;",
				new[]
				{
					new SqlParameter("@PriceAdvantagePercent", System.Data.SqlDbType.Decimal) { Value = (object)_priceAdvantagePercent ?? DBNull.Value},
					new SqlParameter("@PriceAdvantageRuble", System.Data.SqlDbType.Decimal) { Value = (object)_priceAdvantageRuble ?? DBNull.Value},
					new SqlParameter("@BasePriceGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_basePriceGuid ?? DBNull.Value},
					new SqlParameter("@RevaluationBalances", System.Data.SqlDbType.Bit) { Value = (object)_revaluationBalances ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRuleCopy 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleCopy] @RuleGuid uniqueidentifier, @RetailGuid uniqueidentifier, @StatusGuid uniqueidentifier, @UserGuid uniqueidentifier AS...)
public static void PricingRuleCopy (Guid? _ruleGuid, Guid? _retailGuid, Guid? _statusGuid, Guid? _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleCopy] @RuleGuid, @RetailGuid, @StatusGuid, @UserGuid;",
				new[]
				{
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@StatusGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_statusGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRuleCopy 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleCopy] @RuleGuid uniqueidentifier, @RetailGuid uniqueidentifier, @StatusGuid uniqueidentifier, @UserGuid uniqueidentifier AS...)
public static void PricingRuleCopy (object _ruleGuid, object _retailGuid, object _statusGuid, object _userGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleCopy] @RuleGuid, @RetailGuid, @StatusGuid, @UserGuid;",
				new[]
				{
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@StatusGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_statusGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRuleCreate 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleCreate] @RetailGuid uniqueidentifier, @PricingGroupGuid uniqueidentifier, @UserGuid uniqueidentifier, @RuleGuid uniqueidentifier = NULL AS...)
public static void PricingRuleCreate (Guid? _retailGuid, Guid? _pricingGroupGuid, Guid? _userGuid, Guid? _ruleGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleCreate] @RetailGuid, @PricingGroupGuid, @UserGuid, @RuleGuid;",
				new[]
				{
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@PricingGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingGroupGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRuleCreate 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleCreate] @RetailGuid uniqueidentifier, @PricingGroupGuid uniqueidentifier, @UserGuid uniqueidentifier, @RuleGuid uniqueidentifier = NULL AS...)
public static void PricingRuleCreate (object _retailGuid, object _pricingGroupGuid, object _userGuid, object _ruleGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleCreate] @RetailGuid, @PricingGroupGuid, @UserGuid, @RuleGuid;",
				new[]
				{
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@PricingGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingGroupGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRuleEdit 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleEdit] @RuleGuid uniqueidentifier, @Title nvarchar(50), @RetailGuid uniqueidentifier, @PricingGroupGuid uniqueidentifier, @MarketingStatusGuid uniqueidentifier, @EditUserGuid uniqueidentifier AS...)
public static void PricingRuleEdit (Guid? _ruleGuid, string? _title, Guid? _retailGuid, Guid? _pricingGroupGuid, Guid? _marketingStatusGuid, Guid? _editUserGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleEdit] @RuleGuid, @Title, @RetailGuid, @PricingGroupGuid, @MarketingStatusGuid, @EditUserGuid;",
				new[]
				{
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
					new SqlParameter("@Title", System.Data.SqlDbType.NVarChar) { Value = (object)_title ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@PricingGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingGroupGuid ?? DBNull.Value},
					new SqlParameter("@MarketingStatusGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_marketingStatusGuid ?? DBNull.Value},
					new SqlParameter("@EditUserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_editUserGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRuleEdit 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRuleEdit] @RuleGuid uniqueidentifier, @Title nvarchar(50), @RetailGuid uniqueidentifier, @PricingGroupGuid uniqueidentifier, @MarketingStatusGuid uniqueidentifier, @EditUserGuid uniqueidentifier AS...)
public static void PricingRuleEdit (object _ruleGuid, object _title, object _retailGuid, object _pricingGroupGuid, object _marketingStatusGuid, object _editUserGuid)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRuleEdit] @RuleGuid, @Title, @RetailGuid, @PricingGroupGuid, @MarketingStatusGuid, @EditUserGuid;",
				new[]
				{
					new SqlParameter("@RuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_ruleGuid ?? DBNull.Value},
					new SqlParameter("@Title", System.Data.SqlDbType.NVarChar) { Value = (object)_title ?? DBNull.Value},
					new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
					new SqlParameter("@PricingGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingGroupGuid ?? DBNull.Value},
					new SqlParameter("@MarketingStatusGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_marketingStatusGuid ?? DBNull.Value},
					new SqlParameter("@EditUserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_editUserGuid ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRulesMonthEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRulesMonthEditOrCreated] @Num int, @PricingRuleGuid uniqueidentifier, @UserGuid uniqueidentifier, @IsChecked bit = 1 AS...)
public static void PricingRulesMonthEditOrCreated (int? _num, Guid? _pricingRuleGuid, Guid? _userGuid, bool? _isChecked)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRulesMonthEditOrCreated] @Num, @PricingRuleGuid, @UserGuid, @IsChecked;",
				new[]
				{
					new SqlParameter("@Num", System.Data.SqlDbType.Int) { Value = (object)_num ?? DBNull.Value},
					new SqlParameter("@PricingRuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingRuleGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@IsChecked", System.Data.SqlDbType.Bit) { Value = (object)_isChecked ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRulesMonthEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRulesMonthEditOrCreated] @Num int, @PricingRuleGuid uniqueidentifier, @UserGuid uniqueidentifier, @IsChecked bit = 1 AS...)
public static void PricingRulesMonthEditOrCreated (object _num, object _pricingRuleGuid, object _userGuid, object _isChecked)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRulesMonthEditOrCreated] @Num, @PricingRuleGuid, @UserGuid, @IsChecked;",
				new[]
				{
					new SqlParameter("@Num", System.Data.SqlDbType.Int) { Value = (object)_num ?? DBNull.Value},
					new SqlParameter("@PricingRuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingRuleGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@IsChecked", System.Data.SqlDbType.Bit) { Value = (object)_isChecked ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}


// sp_PricingRulesWeekDayEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRulesWeekDayEditOrCreated] @Num int, @PricingRuleGuid uniqueidentifier, @UserGuid uniqueidentifier, @IsChecked bit = 1 AS...)
public static void PricingRulesWeekDayEditOrCreated (int? _num, Guid? _pricingRuleGuid, Guid? _userGuid, bool? _isChecked)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRulesWeekDayEditOrCreated] @Num, @PricingRuleGuid, @UserGuid, @IsChecked;",
				new[]
				{
					new SqlParameter("@Num", System.Data.SqlDbType.Int) { Value = (object)_num ?? DBNull.Value},
					new SqlParameter("@PricingRuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingRuleGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@IsChecked", System.Data.SqlDbType.Bit) { Value = (object)_isChecked ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}
// sp_PricingRulesWeekDayEditOrCreated 
// SQL (CREATE PROCEDURE [dbo].[sp_PricingRulesWeekDayEditOrCreated] @Num int, @PricingRuleGuid uniqueidentifier, @UserGuid uniqueidentifier, @IsChecked bit = 1 AS...)
public static void PricingRulesWeekDayEditOrCreated (object _num, object _pricingRuleGuid, object _userGuid, object _isChecked)
{
	using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
	{
		try
		{
			_db.Database.ExecuteSqlCommand(
				"EXEC [dbo].[sp_PricingRulesWeekDayEditOrCreated] @Num, @PricingRuleGuid, @UserGuid, @IsChecked;",
				new[]
				{
					new SqlParameter("@Num", System.Data.SqlDbType.Int) { Value = (object)_num ?? DBNull.Value},
					new SqlParameter("@PricingRuleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pricingRuleGuid ?? DBNull.Value},
					new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
					new SqlParameter("@IsChecked", System.Data.SqlDbType.Bit) { Value = (object)_isChecked ?? DBNull.Value},
				}
			);
		} catch (Exception ex) { MessageBox.Show(ex.Message); }
	}
}

