
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class ReadGroupsProduct:DbInfor
    {
		#region Đọc dữ liệu bảng GroupsProduct
		static List<GroupsProduct> infor =null;
        public static List<GroupsProduct> ReadingGroupsProduct()
        {
            const string querystring = "Select GroupId, GroupName, Status from GroupsProduct";
			infor =new List<GroupsProduct>();
            if (infor.Count == 0)
            {
				using (SQLiteConnection connection =new SQLiteConnection(connectionString))
				{
					using (SQLiteCommand command = new SQLiteCommand(querystring, connection))
					{
						connection.Open();
						SQLiteDataReader reader = command.ExecuteReader();
						while (reader.Read())
						{
							var entity = new GroupsProduct();
							entity.GroupId = reader["GroupId"] as long? ?? default(long);
							entity.GroupName = reader["GroupName"] as string;
							entity.Status = Convert.ToInt32(reader["Status"])==1? true:false;

							infor.Add(entity);
						}
						reader.Close();
					}
				}
			}

			return infor;
		}
		#endregion
    }
}
