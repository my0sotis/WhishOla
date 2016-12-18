
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Fashion
{
    public class Colors:BaseEntities
    {
		public  Colors(){}
		#region Định nghĩa  Colors

		[Required(ErrorMessage = @"ColorId is required.")]
		public long ColorId { get; set; }//Size:0

		public string ColorName { get; set; }//Size:0

		public string ColorCode { get; set; }//Size:0


		#endregion
		public override string NameE()
        {
            return typeof(Colors).Name;
        }
    }
}