
/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DbGenerate.Fashion
{
    public class ReadProducts:DbInfor
    {
		#region Đọc dữ liệu bảng Products
		static List<Products> infor =null;
        public static List<Products> ReadingProducts()
        {
            const string querystring = "Select ProductId, ProductName, Date(DateImport) as DateImport, Price, Quantity, ProductType, ColorType, Status from Products";
			infor =new List<Products>();
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
							var entity = new Products();
							entity.ProductId = reader["ProductId"] as long? ?? default(long);
							entity.ProductName = reader["ProductName"] as string;
                            var aa = Convert.ToDateTime(reader["DateImport"]);
                            entity.Price = Convert.ToInt32(reader["Price"]);//note
							entity.Quantity = reader["Quantity"] as int? ?? default(int?);
							entity.ProductType = reader["ProductType"] as long? ?? default(long?);
							entity.ColorType = reader["ColorType"] as long? ?? default(long?);
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
