
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Library
{
    public class Products:BaseEntities
    {
		public  Products(){}
		#region Định nghĩa  Products

		[Required(ErrorMessage = @"ProductId is required.")]
		public long ProductId { get; set; }//Size:0

		public string ProductName { get; set; }//Size:0

		public DateTime? DateImport { get; set; }//Size:0

		public int? Price { get; set; }//Size:0

		public int? Quantity { get; set; }//Size:0

		[Required(ErrorMessage = @"ProductType is required.")]
		public long? ProductType { get; set; }//Size:0

		[Required(ErrorMessage = @"ColorType is required.")]
		public long? ColorType { get; set; }//Size:0

		public bool? Status { get; set; }//Size:0


		#endregion
		public override string NameE()
        {
            return typeof(Products).Name;
        }
    }
}