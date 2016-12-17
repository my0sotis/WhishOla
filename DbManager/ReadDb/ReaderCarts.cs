
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class ReadCarts:DbInfor
    {
		#region Đọc dữ liệu bảng Carts
		static List<Carts> infor =null;
        public static List<Carts> ReadingCarts()
        {
            const string querystring = "Select CartId, CustomerName, Sdt, Email, DateCreated, Status from Carts";
			infor =new List<Carts>();
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
							var entity = new Carts();
							entity.CartId = reader["CartId"] as long? ?? default(long);
							entity.CustomerName = reader["CustomerName"] as string;
							entity.Sdt = reader["Sdt"] as string;
							entity.Email = reader["Email"] as string;
                            entity.DateCreated = reader["DateCreated"] as DateTime? ?? default(DateTime?);
						    entity.Status = decimal.Parse(reader["Status"].ToString()) == 1 ? true : false;

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
