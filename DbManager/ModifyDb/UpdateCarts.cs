/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DbGenerate.Library
{
    public class UpdateCarts:UpdateDefined
    {
		#region Thêm dữ liệu vào Carts
        public override int Insert(object data)
        {
            try
            {
                var temp = (Carts)data;
                const string query = @"Insert into Carts (CartId,CustomerName,Sdt,Email,DateCreated,Status) values (@CartId,@CustomerName,@Sdt,@Email,@DateCreated,@Status)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",temp.CartId  as long? ?? default(long));
						command.Parameters.AddWithValue("@CustomerName",temp.CustomerName  as string);
						command.Parameters.AddWithValue("@Sdt",temp.Sdt  as string);
						command.Parameters.AddWithValue("@Email",temp.Email  as string);
						command.Parameters.AddWithValue("@DateCreated",temp.DateCreated  as DateTime? ?? default(DateTime?));
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
        
		#region Sửa dữ liệu Carts
        public override bool Update(object data)
        {

            try
            {
                var temp = (Carts)data;
                const string query = @"Update Carts set CustomerName = @CustomerName,Sdt = @Sdt,Email = @Email,DateCreated = @DateCreated,Status = @Status where  CartId = @CartId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",temp.CartId  as long? ?? default(long));
						command.Parameters.AddWithValue("@CustomerName",temp.CustomerName  as string);
						command.Parameters.AddWithValue("@Sdt",temp.Sdt  as string);
						command.Parameters.AddWithValue("@Email",temp.Email  as string);
						command.Parameters.AddWithValue("@DateCreated",temp.DateCreated  as DateTime? ?? default(DateTime?));
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

		#region Xóa dữ liệu cho Carts
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete Carts where  CartId = @CartId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",key  as long? ?? default(long));

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