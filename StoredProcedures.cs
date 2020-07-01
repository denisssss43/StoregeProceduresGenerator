
using System; 
using System.Windows; 
using System.Data.SqlClient;

namespace ProductApp.Helper
{
	class StoredProcedures
	{

		// sp_AddAssortmentMatrix 
		public static void AddAssortmentMatrix (Guid? _retailGuid, Guid? _productGuid, Guid? _productRoleGuid, Guid? _productAssortmentMatrixChangeGroupGuid, DateTimeOffset? _dateTime, Guid? _userGuid, double? _mICount, double? _cCount, bool? _isPlusMI, bool? _isUnreducedBalance, DateTimeOffset? _dateNew)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AddAssortmentMatrix] @RetailGuid, @ProductGuid, @ProductRoleGuid, @ProductAssortmentMatrixChangeGroupGuid, @DateTime, @UserGuid, @MICount, @CCount, @IsPlusMI, @IsUnreducedBalance, @DateNew;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ProductGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productGuid ?? DBNull.Value},
							new SqlParameter("@ProductRoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productRoleGuid ?? DBNull.Value},
							new SqlParameter("@ProductAssortmentMatrixChangeGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productAssortmentMatrixChangeGroupGuid ?? DBNull.Value},
							new SqlParameter("@DateTime", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateTime ?? DBNull.Value},
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@MICount", System.Data.SqlDbType.Float) { Value = (object)_mICount ?? DBNull.Value},
							new SqlParameter("@CCount", System.Data.SqlDbType.Float) { Value = (object)_cCount ?? DBNull.Value},
							new SqlParameter("@IsPlusMI", System.Data.SqlDbType.Bit) { Value = (object)_isPlusMI ?? DBNull.Value},
							new SqlParameter("@IsUnreducedBalance", System.Data.SqlDbType.Bit) { Value = (object)_isUnreducedBalance ?? DBNull.Value},
							new SqlParameter("@DateNew", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateNew ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AddProduct 
		public static void AddProduct (Guid? _guid, int? _old, string? _title, string? _description, Guid? _manufacturer, Guid? _tradeName, Guid? _brand, Guid? _iNName, Guid? _pharmaGroup, Guid? _category, Guid? _vAT, Guid? _medicineForm, Guid? _package, bool? _isVital, bool? _isReciped, bool? _isAccounted, bool? _isDeleted, DateTimeOffset? _dateCreated, DateTimeOffset? _dateDeleted)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AddProduct] @Guid, @Old, @Title, @Description, @Manufacturer, @TradeName, @Brand, @INName, @PharmaGroup, @Category, @VAT, @MedicineForm, @Package, @IsVital, @IsReciped, @IsAccounted, @IsDeleted, @DateCreated, @DateDeleted;",
						new[]
						{
							new SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
							new SqlParameter("@Old", System.Data.SqlDbType.Int) { Value = (object)_old ?? DBNull.Value},
							new SqlParameter("@Title", System.Data.SqlDbType.NVarChar) { Value = (object)_title ?? DBNull.Value},
							new SqlParameter("@Description", System.Data.SqlDbType.NVarChar) { Value = (object)_description ?? DBNull.Value},
							new SqlParameter("@Manufacturer", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_manufacturer ?? DBNull.Value},
							new SqlParameter("@TradeName", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_tradeName ?? DBNull.Value},
							new SqlParameter("@Brand", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_brand ?? DBNull.Value},
							new SqlParameter("@INName", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_iNName ?? DBNull.Value},
							new SqlParameter("@PharmaGroup", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pharmaGroup ?? DBNull.Value},
							new SqlParameter("@Category", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_category ?? DBNull.Value},
							new SqlParameter("@VAT", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_vAT ?? DBNull.Value},
							new SqlParameter("@MedicineForm", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_medicineForm ?? DBNull.Value},
							new SqlParameter("@Package", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_package ?? DBNull.Value},
							new SqlParameter("@IsVital", System.Data.SqlDbType.Bit) { Value = (object)_isVital ?? DBNull.Value},
							new SqlParameter("@IsReciped", System.Data.SqlDbType.Bit) { Value = (object)_isReciped ?? DBNull.Value},
							new SqlParameter("@IsAccounted", System.Data.SqlDbType.Bit) { Value = (object)_isAccounted ?? DBNull.Value},
							new SqlParameter("@IsDeleted", System.Data.SqlDbType.Bit) { Value = (object)_isDeleted ?? DBNull.Value},
							new SqlParameter("@DateCreated", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateCreated ?? DBNull.Value},
							new SqlParameter("@DateDeleted", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateDeleted ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AddStringToPriceCheck 
		public static void AddStringToPriceCheck (Guid? _shiftKKMGuid, Guid? _retailGuid, Guid? _authorGuid, Guid? _docTypeGuid, double? _discount, string? _barcode, double? _quantity)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AddStringToPriceCheck] @ShiftKKMGuid, @RetailGuid, @AuthorGuid, @DocTypeGuid, @Discount, @Barcode, @Quantity;",
						new[]
						{
							new SqlParameter("@ShiftKKMGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_shiftKKMGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@AuthorGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_authorGuid ?? DBNull.Value},
							new SqlParameter("@DocTypeGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_docTypeGuid ?? DBNull.Value},
							new SqlParameter("@Discount", System.Data.SqlDbType.Float) { Value = (object)_discount ?? DBNull.Value},
							new SqlParameter("@Barcode", System.Data.SqlDbType.NVarChar) { Value = (object)_barcode ?? DBNull.Value},
							new SqlParameter("@Quantity", System.Data.SqlDbType.Float) { Value = (object)_quantity ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_alterdiagram 
		public static void Alterdiagram (string? _diagramname, int? _owner_id, int? _version, string? _definition)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_alterdiagram] @diagramname, @owner_id, @version, @definition;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
							new SqlParameter("@version", System.Data.SqlDbType.Int) { Value = (object)_version ?? DBNull.Value},
							new SqlParameter("@definition", System.Data.SqlDbType.VarChar) { Value = (object)_definition ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixAddImportProduct 
		public static void AssortmentMatrixAddImportProduct (Guid? _userGuid, int? _extCode, string? _titleProduct, string? _titleRole, string? _titleSpecialRole, double? _mICount, double? _cCount, bool? _isPlusMI, bool? _isUnreducedBalance, bool? _isNew)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixAddImportProduct] @UserGuid, @ExtCode, @TitleProduct, @TitleRole, @TitleSpecialRole, @MICount, @CCount, @IsPlusMI, @IsUnreducedBalance, @IsNew;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@ExtCode", System.Data.SqlDbType.Int) { Value = (object)_extCode ?? DBNull.Value},
							new SqlParameter("@TitleProduct", System.Data.SqlDbType.NVarChar) { Value = (object)_titleProduct ?? DBNull.Value},
							new SqlParameter("@TitleRole", System.Data.SqlDbType.NVarChar) { Value = (object)_titleRole ?? DBNull.Value},
							new SqlParameter("@TitleSpecialRole", System.Data.SqlDbType.NVarChar) { Value = (object)_titleSpecialRole ?? DBNull.Value},
							new SqlParameter("@MICount", System.Data.SqlDbType.Float) { Value = (object)_mICount ?? DBNull.Value},
							new SqlParameter("@CCount", System.Data.SqlDbType.Float) { Value = (object)_cCount ?? DBNull.Value},
							new SqlParameter("@IsPlusMI", System.Data.SqlDbType.Bit) { Value = (object)_isPlusMI ?? DBNull.Value},
							new SqlParameter("@IsUnreducedBalance", System.Data.SqlDbType.Bit) { Value = (object)_isUnreducedBalance ?? DBNull.Value},
							new SqlParameter("@IsNew", System.Data.SqlDbType.Bit) { Value = (object)_isNew ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixAddQueue 
		public static void AssortmentMatrixAddQueue (Guid? _queueGuid, Guid? _authorGuid, int? _retailsCount)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixAddQueue] @QueueGuid, @AuthorGuid, @RetailsCount;",
						new[]
						{
							new SqlParameter("@QueueGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_queueGuid ?? DBNull.Value},
							new SqlParameter("@AuthorGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_authorGuid ?? DBNull.Value},
							new SqlParameter("@RetailsCount", System.Data.SqlDbType.Int) { Value = (object)_retailsCount ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixAddQueueProduct 
		public static void AssortmentMatrixAddQueueProduct (Guid? _queueGuid, Guid? _productGuid, Guid? _roleGuid, double? _mICount, double? _cCount, bool? _isPlusMI, bool? _isUnreducedBalance, DateTimeOffset? _dateNew)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixAddQueueProduct] @QueueGuid, @ProductGuid, @RoleGuid, @MICount, @CCount, @IsPlusMI, @IsUnreducedBalance, @DateNew;",
						new[]
						{
							new SqlParameter("@QueueGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_queueGuid ?? DBNull.Value},
							new SqlParameter("@ProductGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productGuid ?? DBNull.Value},
							new SqlParameter("@RoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_roleGuid ?? DBNull.Value},
							new SqlParameter("@MICount", System.Data.SqlDbType.Float) { Value = (object)_mICount ?? DBNull.Value},
							new SqlParameter("@CCount", System.Data.SqlDbType.Float) { Value = (object)_cCount ?? DBNull.Value},
							new SqlParameter("@IsPlusMI", System.Data.SqlDbType.Bit) { Value = (object)_isPlusMI ?? DBNull.Value},
							new SqlParameter("@IsUnreducedBalance", System.Data.SqlDbType.Bit) { Value = (object)_isUnreducedBalance ?? DBNull.Value},
							new SqlParameter("@DateNew", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateNew ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixAddQueueRetail 
		public static void AssortmentMatrixAddQueueRetail (Guid? _queueGuid, Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixAddQueueRetail] @QueueGuid, @RetailGuid;",
						new[]
						{
							new SqlParameter("@QueueGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_queueGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixAddRetailProduct 
		public static void AssortmentMatrixAddRetailProduct (Guid? _retailGuid, Guid? _productGuid, Guid? _productRoleGuid, Guid? _productSpecialRoleGuid, DateTimeOffset? _dateTime, Guid? _userGuid, double? _mICount, double? _cCount, bool? _isPlusMI, bool? _isUnreducedBalance, DateTimeOffset? _dateNew)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixAddRetailProduct] @RetailGuid, @ProductGuid, @ProductRoleGuid, @ProductSpecialRoleGuid, @DateTime, @UserGuid, @MICount, @CCount, @IsPlusMI, @IsUnreducedBalance, @DateNew;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ProductGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productGuid ?? DBNull.Value},
							new SqlParameter("@ProductRoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productRoleGuid ?? DBNull.Value},
							new SqlParameter("@ProductSpecialRoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productSpecialRoleGuid ?? DBNull.Value},
							new SqlParameter("@DateTime", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateTime ?? DBNull.Value},
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@MICount", System.Data.SqlDbType.Float) { Value = (object)_mICount ?? DBNull.Value},
							new SqlParameter("@CCount", System.Data.SqlDbType.Float) { Value = (object)_cCount ?? DBNull.Value},
							new SqlParameter("@IsPlusMI", System.Data.SqlDbType.Bit) { Value = (object)_isPlusMI ?? DBNull.Value},
							new SqlParameter("@IsUnreducedBalance", System.Data.SqlDbType.Bit) { Value = (object)_isUnreducedBalance ?? DBNull.Value},
							new SqlParameter("@DateNew", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateNew ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixCangeImportProduct 
		public static void AssortmentMatrixCangeImportProduct (Guid? _userGuid, int? _extCode, Guid? _roleGuid, Guid? _specialRoleGuid, double? _mICount, double? _cCount, bool? _isPlusMI, bool? _isUnreducedBalance, bool? _isNew)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixCangeImportProduct] @UserGuid, @ExtCode, @RoleGuid, @SpecialRoleGuid, @MICount, @CCount, @IsPlusMI, @IsUnreducedBalance, @IsNew;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@ExtCode", System.Data.SqlDbType.Int) { Value = (object)_extCode ?? DBNull.Value},
							new SqlParameter("@RoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_roleGuid ?? DBNull.Value},
							new SqlParameter("@SpecialRoleGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_specialRoleGuid ?? DBNull.Value},
							new SqlParameter("@MICount", System.Data.SqlDbType.Float) { Value = (object)_mICount ?? DBNull.Value},
							new SqlParameter("@CCount", System.Data.SqlDbType.Float) { Value = (object)_cCount ?? DBNull.Value},
							new SqlParameter("@IsPlusMI", System.Data.SqlDbType.Bit) { Value = (object)_isPlusMI ?? DBNull.Value},
							new SqlParameter("@IsUnreducedBalance", System.Data.SqlDbType.Bit) { Value = (object)_isUnreducedBalance ?? DBNull.Value},
							new SqlParameter("@IsNew", System.Data.SqlDbType.Bit) { Value = (object)_isNew ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixClearImportProducts 
		public static void AssortmentMatrixClearImportProducts (Guid? _userGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixClearImportProducts] @UserGuid;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixImportProductToQueue 
		public static void AssortmentMatrixImportProductToQueue (Guid? _userGuid, Guid? _queueGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixImportProductToQueue] @UserGuid, @QueueGuid;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@QueueGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_queueGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixImportProductValidation 
		public static void AssortmentMatrixImportProductValidation (Guid? _userGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixImportProductValidation] @UserGuid;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_AssortmentMatrixRun 
		public static void AssortmentMatrixRun ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_AssortmentMatrixRun];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_CancelPriceCheck 
		public static void CancelPriceCheck (Guid? _shiftKKMGuid, Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_CancelPriceCheck] @ShiftKKMGuid, @RetailGuid;",
						new[]
						{
							new SqlParameter("@ShiftKKMGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_shiftKKMGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_CloseKKMSession 
		public static void CloseKKMSession (Guid? _numKKM, Guid? _retailGuid, Guid? _authorCloseGuid, Guid? _numReportZ)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_CloseKKMSession] @NumKKM, @RetailGuid, @AuthorCloseGuid, @NumReportZ;",
						new[]
						{
							new SqlParameter("@NumKKM", System.Data.SqlDbType.BigInt) { Value = (object)_numKKM ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@AuthorCloseGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_authorCloseGuid ?? DBNull.Value},
							new SqlParameter("@NumReportZ", System.Data.SqlDbType.BigInt) { Value = (object)_numReportZ ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_creatediagram 
		public static void Creatediagram (string? _diagramname, int? _owner_id, int? _version, string? _definition)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_creatediagram] @diagramname, @owner_id, @version, @definition;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
							new SqlParameter("@version", System.Data.SqlDbType.Int) { Value = (object)_version ?? DBNull.Value},
							new SqlParameter("@definition", System.Data.SqlDbType.VarChar) { Value = (object)_definition ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_DefinitionCashPriceCheck 
		public static void DefinitionCashPriceCheck (Guid? _shiftKKMGuid, Guid? _retailGuid, double? _cash, double? _cashlessMIR, double? _cashlessVISA, double? _cashlessMASTERCARD)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_DefinitionCashPriceCheck] @ShiftKKMGuid, @RetailGuid, @Cash, @CashlessMIR, @CashlessVISA, @CashlessMASTERCARD;",
						new[]
						{
							new SqlParameter("@ShiftKKMGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_shiftKKMGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@Cash", System.Data.SqlDbType.Float) { Value = (object)_cash ?? DBNull.Value},
							new SqlParameter("@CashlessMIR", System.Data.SqlDbType.Float) { Value = (object)_cashlessMIR ?? DBNull.Value},
							new SqlParameter("@CashlessVISA", System.Data.SqlDbType.Float) { Value = (object)_cashlessVISA ?? DBNull.Value},
							new SqlParameter("@CashlessMASTERCARD", System.Data.SqlDbType.Float) { Value = (object)_cashlessMASTERCARD ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_DeleteProduct 
		public static void DeleteProduct (Guid? _guid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_DeleteProduct] @Guid;",
						new[]
						{
							new SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_dropdiagram 
		public static void Dropdiagram (string? _diagramname, int? _owner_id)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_dropdiagram] @diagramname, @owner_id;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_ExportMarketingTerms 
		public static void ExportMarketingTerms ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_ExportMarketingTerms];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetAcceptCharge 
		public static void GetAcceptCharge ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetAcceptCharge];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetCategoryProduct 
		public static void GetCategoryProduct (Guid? _category)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetCategoryProduct] @category;",
						new[]
						{
							new SqlParameter("@category", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_category ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetCategoryProductCount 
		public static void GetCategoryProductCount (Guid? _category)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetCategoryProductCount] @category;",
						new[]
						{
							new SqlParameter("@category", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_category ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetInventory 
		public static void GetInventory (DateTime? _dateInventory, int? _retail)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetInventory] @dateInventory, @retail;",
						new[]
						{
							new SqlParameter("@dateInventory", System.Data.SqlDbType.DateTime) { Value = (object)_dateInventory ?? DBNull.Value},
							new SqlParameter("@retail", System.Data.SqlDbType.Int) { Value = (object)_retail ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetLogNameTable 
		public static void GetLogNameTable ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetLogNameTable];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetLogs 
		public static void GetLogs (DateTimeOffset? _dateFrom, DateTimeOffset? _dateTo, string? _command, string? _table, Guid? _user)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetLogs] @dateFrom, @dateTo, @command, @table, @user;",
						new[]
						{
							new SqlParameter("@dateFrom", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateFrom ?? DBNull.Value},
							new SqlParameter("@dateTo", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateTo ?? DBNull.Value},
							new SqlParameter("@command", System.Data.SqlDbType.NVarChar) { Value = (object)_command ?? DBNull.Value},
							new SqlParameter("@table", System.Data.SqlDbType.NVarChar) { Value = (object)_table ?? DBNull.Value},
							new SqlParameter("@user", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_user ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetLogUsers 
		public static void GetLogUsers ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetLogUsers];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetOpenedKKMSession 
		public static void GetOpenedKKMSession (Guid? _numKKM, Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetOpenedKKMSession] @NumKKM, @RetailGuid;",
						new[]
						{
							new SqlParameter("@NumKKM", System.Data.SqlDbType.BigInt) { Value = (object)_numKKM ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetOpenedPriceCheck 
		public static void GetOpenedPriceCheck (Guid? _shiftKKMGuid, Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetOpenedPriceCheck] @ShiftKKMGuid, @RetailGuid;",
						new[]
						{
							new SqlParameter("@ShiftKKMGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_shiftKKMGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductByGuid 
		public static void GetProductByGuid (Guid? _guid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductByGuid] @Guid;",
						new[]
						{
							new SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProducts 
		public static void GetProducts ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProducts];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsByBrand 
		public static void GetProductsByBrand (Guid? _brandGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsByBrand] @brandGuid;",
						new[]
						{
							new SqlParameter("@brandGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_brandGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsByINName 
		public static void GetProductsByINName (Guid? _innameGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsByINName] @innameGuid;",
						new[]
						{
							new SqlParameter("@innameGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_innameGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsByPharmGroup 
		public static void GetProductsByPharmGroup (Guid? _pharmaGroupGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsByPharmGroup] @pharmaGroupGuid;",
						new[]
						{
							new SqlParameter("@pharmaGroupGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pharmaGroupGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsByTradeName 
		public static void GetProductsByTradeName (Guid? _tradeNameGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsByTradeName] @tradeNameGuid;",
						new[]
						{
							new SqlParameter("@tradeNameGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_tradeNameGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsByVAT 
		public static void GetProductsByVAT (Guid? _vatGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsByVAT] @vatGuid;",
						new[]
						{
							new SqlParameter("@vatGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_vatGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsCalculation 
		public static void GetProductsCalculation (DateTime? _dateFrom, DateTime? _dateTo, Guid? _category, string? _retails)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsCalculation] @dateFrom, @dateTo, @category, @retails;",
						new[]
						{
							new SqlParameter("@dateFrom", System.Data.SqlDbType.DateTime) { Value = (object)_dateFrom ?? DBNull.Value},
							new SqlParameter("@dateTo", System.Data.SqlDbType.DateTime) { Value = (object)_dateTo ?? DBNull.Value},
							new SqlParameter("@category", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_category ?? DBNull.Value},
							new SqlParameter("@retails", System.Data.SqlDbType.NVarChar) { Value = (object)_retails ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProductsCount 
		public static void GetProductsCount ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProductsCount];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetProfitEmployee 
		public static void GetProfitEmployee (int? _retail, DateTime? _date)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetProfitEmployee] @retail, @date;",
						new[]
						{
							new SqlParameter("@retail", System.Data.SqlDbType.Int) { Value = (object)_retail ?? DBNull.Value},
							new SqlParameter("@date", System.Data.SqlDbType.DateTime) { Value = (object)_date ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetSumAcceptCharge 
		public static void GetSumAcceptCharge (int? _month, int? _year)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetSumAcceptCharge] @month, @year;",
						new[]
						{
							new SqlParameter("@month", System.Data.SqlDbType.Int) { Value = (object)_month ?? DBNull.Value},
							new SqlParameter("@year", System.Data.SqlDbType.Int) { Value = (object)_year ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetSummarySchedule 
		public static void GetSummarySchedule (int? _month, int? _year)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetSummarySchedule] @month, @year;",
						new[]
						{
							new SqlParameter("@month", System.Data.SqlDbType.Int) { Value = (object)_month ?? DBNull.Value},
							new SqlParameter("@year", System.Data.SqlDbType.Int) { Value = (object)_year ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetSummaryScheduleDepartment 
		public static void GetSummaryScheduleDepartment (int? _month, int? _year)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetSummaryScheduleDepartment] @month, @year;",
						new[]
						{
							new SqlParameter("@month", System.Data.SqlDbType.Int) { Value = (object)_month ?? DBNull.Value},
							new SqlParameter("@year", System.Data.SqlDbType.Int) { Value = (object)_year ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetSummaryTimesheet 
		public static void GetSummaryTimesheet (int? _month, int? _year)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetSummaryTimesheet] @month, @year;",
						new[]
						{
							new SqlParameter("@month", System.Data.SqlDbType.Int) { Value = (object)_month ?? DBNull.Value},
							new SqlParameter("@year", System.Data.SqlDbType.Int) { Value = (object)_year ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_GetSummaryTimesheetDepartment 
		public static void GetSummaryTimesheetDepartment (int? _month, int? _year)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_GetSummaryTimesheetDepartment] @month, @year;",
						new[]
						{
							new SqlParameter("@month", System.Data.SqlDbType.Int) { Value = (object)_month ?? DBNull.Value},
							new SqlParameter("@year", System.Data.SqlDbType.Int) { Value = (object)_year ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_helpdiagramdefinition 
		public static void Helpdiagramdefinition (string? _diagramname, int? _owner_id)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_helpdiagramdefinition] @diagramname, @owner_id;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_helpdiagrams 
		public static void Helpdiagrams (string? _diagramname, int? _owner_id)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_helpdiagrams] @diagramname, @owner_id;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_IndividualSalesRun 
		public static void IndividualSalesRun ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_IndividualSalesRun];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_IsInvoiceItemMappedToProduct 
		public static void IsInvoiceItemMappedToProduct (Guid? _guid, bool? _result)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_IsInvoiceItemMappedToProduct] @guid, @result;",
						new[]
						{
							new SqlParameter("@guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
							new SqlParameter("@result", System.Data.SqlDbType.Bit) { Value = (object)_result ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_IsInvoiceMappedToProducts 
		public static void IsInvoiceMappedToProducts (Guid? _guid, bool? _result)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_IsInvoiceMappedToProducts] @guid, @result;",
						new[]
						{
							new SqlParameter("@guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
							new SqlParameter("@result", System.Data.SqlDbType.Bit) { Value = (object)_result ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_PricingGlobalSettingsEdit 
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
		
		// sp_PricingRangesEditOrCreated 
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
		
		// sp_PricingRetailSettingsEdit 
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
		
		// sp_PricingRuleCopy 
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
		
		// sp_PricingRuleCreate 
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
		
		// sp_PricingRuleEdit 
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
		
		// sp_PricingRulesMonthEditOrCreated 
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
		
		// sp_PricingRulesWeekDayEditOrCreated 
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
		
		// sp_ProductsExtcodeUpdate 
		public static void ProductsExtcodeUpdate ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_ProductsExtcodeUpdate];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_ProductsInctivate 
		public static void ProductsInctivate ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_ProductsInctivate];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_renamediagram 
		public static void Renamediagram (string? _diagramname, int? _owner_id, string? _new_diagramname)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_renamediagram] @diagramname, @owner_id, @new_diagramname;",
						new[]
						{
							new SqlParameter("@diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_diagramname ?? DBNull.Value},
							new SqlParameter("@owner_id", System.Data.SqlDbType.Int) { Value = (object)_owner_id ?? DBNull.Value},
							new SqlParameter("@new_diagramname", System.Data.SqlDbType.NVarChar) { Value = (object)_new_diagramname ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_RetailsExtcodeUpdate 
		public static void RetailsExtcodeUpdate ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_RetailsExtcodeUpdate];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_SuppliersExtcodeUpdate 
		public static void SuppliersExtcodeUpdate ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_SuppliersExtcodeUpdate];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesAdd 
		public static void UnreducedBalancesAdd (Guid? _retailGuid, Guid? _productGuid, decimal? _maxOst, decimal? _qnorm, decimal? _qpolka, decimal? _quantity, DateTime? _dateEditable)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesAdd] @RetailGuid, @ProductGuid, @MaxOst, @Qnorm, @Qpolka, @Quantity, @DateEditable;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ProductGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_productGuid ?? DBNull.Value},
							new SqlParameter("@MaxOst", System.Data.SqlDbType.Decimal) { Value = (object)_maxOst ?? DBNull.Value},
							new SqlParameter("@Qnorm", System.Data.SqlDbType.Decimal) { Value = (object)_qnorm ?? DBNull.Value},
							new SqlParameter("@Qpolka", System.Data.SqlDbType.Decimal) { Value = (object)_qpolka ?? DBNull.Value},
							new SqlParameter("@Quantity", System.Data.SqlDbType.Decimal) { Value = (object)_quantity ?? DBNull.Value},
							new SqlParameter("@DateEditable", System.Data.SqlDbType.DateTime) { Value = (object)_dateEditable ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesAddAll 
		public static void UnreducedBalancesAddAll ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesAddAll];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesAddExceptionDate 
		public static void UnreducedBalancesAddExceptionDate (Guid? _userGuid, Guid? _retailGuid, DateTime? _date)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesAddExceptionDate] @UserGuid, @RetailGuid, @Date;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@Date", System.Data.SqlDbType.Date) { Value = (object)_date ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesAddRetail 
		public static void UnreducedBalancesAddRetail (Guid? _retailGuid, Guid? _userGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesAddRetail] @RetailGuid, @UserGuid;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesCopyExceptionDateParametersToExceptionDate 
		public static void UnreducedBalancesCopyExceptionDateParametersToExceptionDate (Guid? _userGuid, Guid? _retailGuidFrom, DateTime? _exeptionDateFrom, Guid? _retailGuidTo, DateTime? _exeptionDateTo)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesCopyExceptionDateParametersToExceptionDate] @UserGuid, @RetailGuidFrom, @ExeptionDateFrom, @RetailGuidTo, @ExeptionDateTo;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuidFrom", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidFrom ?? DBNull.Value},
							new SqlParameter("@ExeptionDateFrom", System.Data.SqlDbType.Date) { Value = (object)_exeptionDateFrom ?? DBNull.Value},
							new SqlParameter("@RetailGuidTo", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidTo ?? DBNull.Value},
							new SqlParameter("@ExeptionDateTo", System.Data.SqlDbType.Date) { Value = (object)_exeptionDateTo ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesCopyRetailParametersToRetail 
		public static void UnreducedBalancesCopyRetailParametersToRetail (Guid? _userGuid, Guid? _retailGuidFrom, Guid? _retailGuidTo)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesCopyRetailParametersToRetail] @UserGuid, @RetailGuidFrom, @RetailGuidTo;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuidFrom", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidFrom ?? DBNull.Value},
							new SqlParameter("@RetailGuidTo", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidTo ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesCopyWeekParametersToWeek 
		public static void UnreducedBalancesCopyWeekParametersToWeek (Guid? _userGuid, Guid? _retailGuidFrom, int? _weekDayFrom, Guid? _retailGuidTo, int? _weekDayTo)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesCopyWeekParametersToWeek] @UserGuid, @RetailGuidFrom, @WeekDayFrom, @RetailGuidTo, @WeekDayTo;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuidFrom", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidFrom ?? DBNull.Value},
							new SqlParameter("@WeekDayFrom", System.Data.SqlDbType.Int) { Value = (object)_weekDayFrom ?? DBNull.Value},
							new SqlParameter("@RetailGuidTo", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuidTo ?? DBNull.Value},
							new SqlParameter("@WeekDayTo", System.Data.SqlDbType.Int) { Value = (object)_weekDayTo ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesDeleteExceptionDate 
		public static void UnreducedBalancesDeleteExceptionDate (Guid? _retailGuid, DateTime? _exeptionDate)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesDeleteExceptionDate] @RetailGuid, @ExeptionDate;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ExeptionDate", System.Data.SqlDbType.Date) { Value = (object)_exeptionDate ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesGetFreeExceptionsDateList 
		public static void UnreducedBalancesGetFreeExceptionsDateList (Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesGetFreeExceptionsDateList] @RetailGuid;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesGetParametersExceptionsDateList 
		public static void UnreducedBalancesGetParametersExceptionsDateList (Guid? _retailGuid)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesGetParametersExceptionsDateList] @RetailGuid;",
						new[]
						{
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesRun 
		public static void UnreducedBalancesRun ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesRun];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesSetExceptionDateParameterValue 
		public static void UnreducedBalancesSetExceptionDateParameterValue (Guid? _userGuid, Guid? _retailGuid, Guid? _parametrGuid, DateTime? _date, double? _value)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesSetExceptionDateParameterValue] @UserGuid, @RetailGuid, @ParametrGuid, @Date, @Value;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ParametrGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_parametrGuid ?? DBNull.Value},
							new SqlParameter("@Date", System.Data.SqlDbType.Date) { Value = (object)_date ?? DBNull.Value},
							new SqlParameter("@Value", System.Data.SqlDbType.Float) { Value = (object)_value ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UnreducedBalancesSetWeekParameterValue 
		public static void UnreducedBalancesSetWeekParameterValue (Guid? _userGuid, Guid? _retailGuid, Guid? _parametrGuid, int? _weekDay, double? _value)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UnreducedBalancesSetWeekParameterValue] @UserGuid, @RetailGuid, @ParametrGuid, @WeekDay, @Value;",
						new[]
						{
							new SqlParameter("@UserGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_userGuid ?? DBNull.Value},
							new SqlParameter("@RetailGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_retailGuid ?? DBNull.Value},
							new SqlParameter("@ParametrGuid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_parametrGuid ?? DBNull.Value},
							new SqlParameter("@WeekDay", System.Data.SqlDbType.Int) { Value = (object)_weekDay ?? DBNull.Value},
							new SqlParameter("@Value", System.Data.SqlDbType.Float) { Value = (object)_value ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_UpdateProduct 
		public static void UpdateProduct (Guid? _guid, int? _old, string? _title, string? _description, Guid? _manufacturer, Guid? _tradeName, Guid? _brand, Guid? _iNName, Guid? _pharmaGroup, Guid? _category, Guid? _vAT, Guid? _medicineForm, Guid? _package, bool? _isVital, bool? _isReciped, bool? _isAccounted, bool? _isDeleted, DateTimeOffset? _dateDeleted)
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_UpdateProduct] @Guid, @Old, @Title, @Description, @Manufacturer, @TradeName, @Brand, @INName, @PharmaGroup, @Category, @VAT, @MedicineForm, @Package, @IsVital, @IsReciped, @IsAccounted, @IsDeleted, @DateDeleted;",
						new[]
						{
							new SqlParameter("@Guid", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_guid ?? DBNull.Value},
							new SqlParameter("@Old", System.Data.SqlDbType.Int) { Value = (object)_old ?? DBNull.Value},
							new SqlParameter("@Title", System.Data.SqlDbType.NVarChar) { Value = (object)_title ?? DBNull.Value},
							new SqlParameter("@Description", System.Data.SqlDbType.NVarChar) { Value = (object)_description ?? DBNull.Value},
							new SqlParameter("@Manufacturer", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_manufacturer ?? DBNull.Value},
							new SqlParameter("@TradeName", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_tradeName ?? DBNull.Value},
							new SqlParameter("@Brand", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_brand ?? DBNull.Value},
							new SqlParameter("@INName", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_iNName ?? DBNull.Value},
							new SqlParameter("@PharmaGroup", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_pharmaGroup ?? DBNull.Value},
							new SqlParameter("@Category", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_category ?? DBNull.Value},
							new SqlParameter("@VAT", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_vAT ?? DBNull.Value},
							new SqlParameter("@MedicineForm", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_medicineForm ?? DBNull.Value},
							new SqlParameter("@Package", System.Data.SqlDbType.UniqueIdentifier) { Value = (object)_package ?? DBNull.Value},
							new SqlParameter("@IsVital", System.Data.SqlDbType.Bit) { Value = (object)_isVital ?? DBNull.Value},
							new SqlParameter("@IsReciped", System.Data.SqlDbType.Bit) { Value = (object)_isReciped ?? DBNull.Value},
							new SqlParameter("@IsAccounted", System.Data.SqlDbType.Bit) { Value = (object)_isAccounted ?? DBNull.Value},
							new SqlParameter("@IsDeleted", System.Data.SqlDbType.Bit) { Value = (object)_isDeleted ?? DBNull.Value},
							new SqlParameter("@DateDeleted", System.Data.SqlDbType.DateTimeOffset) { Value = (object)_dateDeleted ?? DBNull.Value},
						}
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
		// sp_upgraddiagrams 
		public static void Upgraddiagrams ()
		{
			using (GZEntities _db = new GZEntities(DbConnectionString.GZEntity.ConnectionString))
			{
				try
				{
					_db.Database.ExecuteSqlCommand(
						"EXEC [dbo].[sp_upgraddiagrams];"
					);
				} catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
		}
		
	}
}
