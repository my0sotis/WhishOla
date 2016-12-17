/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class UpdateGroupsProduct:UpdateDefined
    {
		#region Thêm dữ liệu vào GroupsProduct
        public override int Insert(object data)
        {
            try
            {
                var temp = (GroupsProduct)data;
                const string query = @"Insert into GroupsProduct (GroupId,GroupName,Status) values (@GroupId,@GroupName,@Status)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@GroupId",temp.GroupId  as long? ?? default(long));
						command.Parameters.AddWithValue("@GroupName",temp.GroupName  as string);
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
        
		#region Sửa dữ liệu GroupsProduct
        public override bool Update(object data)
        {

            try
            {
                var temp = (GroupsProduct)data;
                const string query = @"Update GroupsProduct set GroupName = @GroupName,Status = @Status where  GroupId = @GroupId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@GroupId",temp.GroupId  as long? ?? default(long));
						command.Parameters.AddWithValue("@GroupName",temp.GroupName  as string);
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

		#region Xóa dữ liệu cho GroupsProduct
        public override bool Delete(object _key)
        {
            try
            {
				var key=(long) _key;
                const string query = @"Delete GroupsProduct where  GroupId = @GroupId ";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
						command.Parameters.AddWithValue("@GroupId",key  as long? ?? default(long));

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