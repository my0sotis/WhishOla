/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DbGenerate.Library
{
    public class UpdateColors:UpdateDefined
    {
		#region Thêm dữ liệu vào Colors
        public override int Insert(object data)
        {
            try
            {
                var temp = (Colors)data;
                const string query = @"Insert into Colors (ColorId,ColorName,ColorCode) values (@ColorId,@ColorName,@ColorCode)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ColorId",temp.ColorId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ColorName",temp.ColorName  as string);
						command.Parameters.AddWithValue("@ColorCode",temp.ColorCode  as string);

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
        
		#region Sửa dữ liệu Colors
        public override bool Update(object data)
        {

            try
            {
                var temp = (Colors)data;
                const string query = @"Update Colors set ColorName = @ColorName,ColorCode = @ColorCode where  ColorId = @ColorId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ColorId",temp.ColorId  as long? ?? default(long));
						command.Parameters.AddWithValue("@ColorName",temp.ColorName  as string);
						command.Parameters.AddWithValue("@ColorCode",temp.ColorCode  as string);

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

		#region Xóa dữ liệu cho Colors
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete Colors where  ColorId = @ColorId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@ColorId",key  as long? ?? default(long));

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