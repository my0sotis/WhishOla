using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Library;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Set Gía trị từng Field
        public static void SetMemory(Products dic)
        {
			if (!ProductsDic.ContainsKey(dic.ProductId))
            {
                MakeKey(dic);
                _ProductsUpdate.Insert(dic);
                
            }
            else _ProductsUpdate.Update(dic);
            ProductsDic[dic.ProductId] = dic;
            
        }
        public static void SetMemory(Colors dic)
        {
			if (!ColorsDic.ContainsKey(dic.ColorId))
            {
                MakeKey(dic);
                _ColorsUpdate.Insert(dic);
                
            }
            else _ColorsUpdate.Update(dic);
            ColorsDic[dic.ColorId] = dic;
            
        }
        public static void SetMemory(GroupsProduct dic)
        {
			if (!GroupsProductDic.ContainsKey(dic.GroupId))
            {
                MakeKey(dic);
                _GroupsProductUpdate.Insert(dic);
                
            }
            else _GroupsProductUpdate.Update(dic);
            GroupsProductDic[dic.GroupId] = dic;
            
        }
        public static void SetMemory(CartDetail cartdetailkeys)
        {
            var key = new CartDetailKeys()
            {
				CartId = cartdetailkeys.CartId,
				ProductId = cartdetailkeys.ProductId,

            };
			if (!CartDetailDic.ContainsKey(key))
            {
                _CartDetailUpdate.Insert(cartdetailkeys);
            }
            else
            {
                _CartDetailUpdate.Update(cartdetailkeys);
            }
            CartDetailDic[key] = cartdetailkeys;
        }
        public static void SetMemory(Carts dic)
        {
			if (!CartsDic.ContainsKey(dic.CartId))
            {
                MakeKey(dic);
                _CartsUpdate.Insert(dic);
                
            }
            else _CartsUpdate.Update(dic);
            CartsDic[dic.CartId] = dic;
            
        }

        #endregion
        
        #region SetAll
            
        #endregion
    }
}
