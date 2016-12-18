using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Fashion;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Xóa field trong Dic
        public static void RemoveMemory(Products objectValue)
        {
            if (ProductsDic.ContainsKey(objectValue.ProductId))
			{
				ProductsDic.Remove(objectValue.ProductId);
                _ProductsUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(Colors objectValue)
        {
            if (ColorsDic.ContainsKey(objectValue.ColorId))
			{
				ColorsDic.Remove(objectValue.ColorId);
                _ColorsUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(GroupsProduct objectValue)
        {
            if (GroupsProductDic.ContainsKey(objectValue.GroupId))
			{
				GroupsProductDic.Remove(objectValue.GroupId);
                _GroupsProductUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(CartDetailKeys objectValue)
        {
            if (CartDetailDic.ContainsKey(objectValue))
			{
				CartDetailDic.Remove(objectValue);
                _CartDetailUpdate.Delete(objectValue);
			}
                
        }
        public static void RemoveMemory(Carts objectValue)
        {
            if (CartsDic.ContainsKey(objectValue.CartId))
			{
				CartsDic.Remove(objectValue.CartId);
                _CartsUpdate.Delete(objectValue);
			}
                
        }

	 
        #endregion
        
    }
}
