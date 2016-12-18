/*generate by tool EntityGenerate
 *Author:ManhTe
 */
using System;

namespace DbGenerate.Library
{
 public class CartDetailKeys
    {
		public long CartId { get; set; }//MaxSize:0

		public long ProductId { get; set; }//MaxSize:0


            
        public override int GetHashCode()
        {
            unchecked
            {        
				int result;
				result = CartId.GetHashCode();
				result = (result * 397) ^ ProductId.GetHashCode();

                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is CartDetailKeys)
            {
                var item = obj as CartDetailKeys;
				return CartId == item.CartId && ProductId == item.ProductId;
            }
            return false;
        }
    }
}