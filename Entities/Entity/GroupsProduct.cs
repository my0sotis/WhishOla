
using System;
using System.ComponentModel.DataAnnotations;

namespace DbGenerate.Fashion
{
    public class GroupsProduct:BaseEntities
    {
		public  GroupsProduct(){}
		#region Định nghĩa  GroupsProduct

		[Required(ErrorMessage = @"GroupId is required.")]
		public long GroupId { get; set; }//Size:0

		public string GroupName { get; set; }//Size:0

		public bool? Status { get; set; }//Size:0


		#endregion
		public override string NameE()
        {
            return typeof(GroupsProduct).Name;
        }
    }
}