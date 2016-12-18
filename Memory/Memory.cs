/*generate by tool EntityGenerate
 *Author:ManhTe
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Fashion;

namespace CreateDictionary.Memory
{
    public class Memory
    {
		 public static Dictionary<string, object> KeyDic = new Dictionary<string, object>();
			protected static Dictionary<long,Products> ProductsDic = new Dictionary<long, Products>();

			protected static Dictionary<long,Colors> ColorsDic = new Dictionary<long, Colors>();

			protected static Dictionary<long,GroupsProduct> GroupsProductDic = new Dictionary<long, GroupsProduct>();

			protected static Dictionary<CartDetailKeys,CartDetail> CartDetailDic = new Dictionary<CartDetailKeys, CartDetail>();

			protected static Dictionary<long,Carts> CartsDic = new Dictionary<long, Carts>();

            /*
             * Update
             */
			protected static UpdateProducts _ProductsUpdate = new UpdateProducts();

			protected static UpdateColors _ColorsUpdate = new UpdateColors();

			protected static UpdateGroupsProduct _GroupsProductUpdate = new UpdateGroupsProduct();

			protected static UpdateCartDetail _CartDetailUpdate = new UpdateCartDetail();

			protected static UpdateCarts _CartsUpdate = new UpdateCarts();


   
    }
}
