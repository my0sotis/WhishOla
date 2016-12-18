/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DbGenerate.Library
{
    public class UpdateProducts:UpdateDefined
    {
		#region Thêm dữ liệu vào Products
        public override int Insert(object data)
        {
            try
            {
                var temp = (Products)data;
                const string query = @"Insert into Products (ProductId,ProductName,DateImport,Price,Quantity,ProductType,ColorType,Status) values (@ProductId,@ProductName,@DateImport,@Price,@Quantity,@ProductType,@ColorType,@Status)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ProductId",temp.ProductId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ProductName",temp.ProductName  as string);
						command.Parameters.AddWithValue("@DateImport",temp.DateImport  as DateTime? ?? default(DateTime?));
						command.Parameters.AddWithValue("@Price",temp.Price  as int? ?? default(int?));
						command.Parameters.AddWithValue("@Quantity",temp.Quantity  as int? ?? default(int?));
						command.Parameters.AddWithValue("@ProductType",temp.ProductType  as long? ?? default(long?));
						command.Parameters.AddWithValue("@ColorType",temp.ColorType  as long? ?? default(long?));
						command.Parameters.AddWithValue("@Status",temp.Status  as bool? ?? default(bool?));

                        connection.Open();
                        var i=command.ExecuteNonQuery();
                        connection.Close();
                        return i;
                    }
                }
            }
            catch (Exception)
            {
                return -1;   
                throw;
            }
        }
		#endregion
        
		#region Sửa dữ liệu Products
        public override bool Update(object data)
        {

            try
            {
                var temp = (Products)data;
                const string query = @"Update Products set ProductName = @ProductName,DateImport = @DateImport,Price = @Price,Quantity = @Quantity,ProductType = @ProductType,ColorType = @ColorType,Status = @Status where  ProductId = @ProductId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ProductId",temp.ProductId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ProductName",temp.ProductName  as string);
						command.Parameters.AddWithValue("@DateImport",temp.DateImport  as DateTime? ?? default(DateTime?));
						command.Parameters.AddWithValue("@Price",temp.Price  as int? ?? default(int?));
						command.Parameters.AddWithValue("@Quantity",temp.Quantity  as int? ?? default(int?));
						command.Parameters.AddWithValue("@ProductType",temp.ProductType  as long? ?? default(long?));
						command.Parameters.AddWithValue("@ColorType",temp.ColorType  as long? ?? default(long?));
						command.Parameters.AddWithValue("@Status",temp.Status  as bool? ?? default(bool?));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
		#endregion

		#region Xóa dữ liệu cho Products
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete Products where  ProductId = @ProductId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ProductId",key  as long? ?? default(long));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
		#endregion
    }
}