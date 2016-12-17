
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class ReadColors:DbInfor
    {
		#region Đọc dữ liệu bảng Colors
		static List<Colors> infor =null;
        public static List<Colors> ReadingColors()
        {
            const string querystring = "Select ColorId, ColorName, ColorCode from Colors";
			infor =new List<Colors>();
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
							var entity = new Colors();
							entity.ColorId = reader["ColorId"] as long? ?? default(long);
							entity.ColorName = reader["ColorName"] as string;
							entity.ColorCode = reader["ColorCode"] as string;

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
