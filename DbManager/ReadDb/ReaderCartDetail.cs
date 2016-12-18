
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DbGenerate.Library
{
    public class ReadCartDetail:DbInfor
    {
		#region Đọc dữ liệu bảng CartDetail
		static List<CartDetail> infor =null;
        public static List<CartDetail> ReadingCartDetail()
        {
            const string querystring = "Select CartId, ProductId, Quatity, Sale, Status from CartDetail";
			infor =new List<CartDetail>();
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
							var entity = new CartDetail();
							entity.CartId = reader["CartId"] as long? ?? default(long);
							entity.ProductId = reader["ProductId"] as long? ?? default(long);
							entity.Quatity = reader["Quatity"] as long? ?? default(long?);
							entity.Sale = reader["Sale"] as double? ?? default(double?);
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
