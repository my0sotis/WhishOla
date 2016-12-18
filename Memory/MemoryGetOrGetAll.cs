using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Library;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        #region Lấy theo mã
        public static Products GetProducts(long products)
        {
            if (ProductsDic.ContainsKey(products))
                return ProductsDic[products].Clone() as Products;
            return null;
        }
        public static Colors GetColors(long colors)
        {
            if (ColorsDic.ContainsKey(colors))
                return ColorsDic[colors].Clone() as Colors;
            return null;
        }
        public static GroupsProduct GetGroupsProduct(long groupsproduct)
        {
            if (GroupsProductDic.ContainsKey(groupsproduct))
                return GroupsProductDic[groupsproduct].Clone() as GroupsProduct;
            return null;
        }
        public static CartDetail GetCartDetail(CartDetailKeys cartdetail)
        {
            if (CartDetailDic.ContainsKey(cartdetail))
                return CartDetailDic[cartdetail].Clone() as CartDetail;
            return null;
        }
        public static Carts GetCarts(long carts)
        {
            if (CartsDic.ContainsKey(carts))
                return CartsDic[carts].Clone() as Carts;
            return null;
        }

        #endregion
        
        #region Lấy tất cả List
        public static List<Products> GetAllProducts()
        {
            return ProductsDic.Select(obj => obj.Value.Clone() as Products).ToList();
        }
        public static List<Colors> GetAllColors()
        {
            return ColorsDic.Select(obj => obj.Value.Clone() as Colors).ToList();
        }
        public static List<GroupsProduct> GetAllGroupsProduct()
        {
            return GroupsProductDic.Select(obj => obj.Value.Clone() as GroupsProduct).ToList();
        }
        public static List<CartDetail> GetAllCartDetail()
        {
            return CartDetailDic.Select(obj => obj.Value.Clone() as CartDetail).ToList();
        }
        public static List<Carts> GetAllCarts()
        {
            return CartsDic.Select(obj => obj.Value.Clone() as Carts).ToList();
        }

        #endregion
        
    }
}
