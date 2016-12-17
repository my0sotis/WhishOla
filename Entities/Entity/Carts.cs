
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Fashion
{
    public class Carts:BaseEntities
    {
		public  Carts(){}
		#region Định nghĩa  Carts

		[Required(ErrorMessage = @"CartId is required.")]
		public long CartId { get; set; }//Size:0

		public string CustomerName { get; set; }//Size:0

		public string Sdt { get; set; }//Size:0

		public string Email { get; set; }//Size:0

		public DateTime? DateCreated { get; set; }//Size:0

		public bool? Status { get; set; }//Size:0


		#endregion
		public override string NameE()
        {
            return typeof(Carts).Name;
        }
    }
}