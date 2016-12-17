/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class UpdateCartDetail:UpdateDefined
    {
		#region Thêm dữ liệu vào CartDetail
        public override int Insert(object data)
        {
            try
            {
                var temp = (CartDetail)data;
                const string query = @"Insert into CartDetail (CartId,ProductId,Quatity,Sale,Status) values (@CartId,@ProductId,@Quatity,@Sale,@Status)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",temp.CartId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ProductId",temp.ProductId  as long? ?? default(long));
						command.Parameters.AddWithValue("@Quatity",temp.Quatity  as long? ?? default(long?));
						command.Parameters.AddWithValue("@Sale",temp.Sale  as double? ?? default(double?));
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
        
		#region Sửa dữ liệu CartDetail
        public override bool Update(object data)
        {

            try
            {
                var temp = (CartDetail)data;
                const string query = @"Update CartDetail set Quatity = @Quatity,Sale = @Sale,Status = @Status where  CartId = @CartId  AND  ProductId = @ProductId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",temp.CartId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ProductId",temp.ProductId  as long? ?? default(long));
						command.Parameters.AddWithValue("@Quatity",temp.Quatity  as long? ?? default(long?));
						command.Parameters.AddWithValue("@Sale",temp.Sale  as double? ?? default(double?));
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

		#region Xóa dữ liệu cho CartDetail
        public override bool Delete(object _key)
        {
            try
            {
				var key=(CartDetailKeys) _key;
                const string query = @"Delete CartDetail where  CartId = @CartId  AND  ProductId = @ProductId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@CartId",key.CartId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ProductId",key.ProductId  as long? ?? default(long));

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