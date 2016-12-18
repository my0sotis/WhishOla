
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Fashion
{
    public class CartDetail:BaseEntities
    {
		public  CartDetail(){}
		#region Định nghĩa  CartDetail

		[Required(ErrorMessage = @"CartId is required.")]
		public long CartId { get; set; }//Size:0

		[Required(ErrorMessage = @"ProductId is required.")]
		public long ProductId { get; set; }//Size:0

		[Required(ErrorMessage = @"Quatity is required.")]
		public long? Quatity { get; set; }//Size:0

		public double? Sale { get; set; }//Size:0

		public bool? Status { get; set; }//Size:0


		#endregion
		public override string NameE()
        {
            return typeof(CartDetail).Name;
        }
    }
}