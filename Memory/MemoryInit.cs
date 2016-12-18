using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbGenerate.Library;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        public static void  InitMemory()
        {
            #region lấy dữ liệu vào Memory từ Db
            ReadProducts.ReadingProducts().ForEach( obj => {  MakeKey(obj); ProductsDic.Add(obj.ProductId, obj);} );

            ReadColors.ReadingColors().ForEach( obj => {  MakeKey(obj); ColorsDic.Add(obj.ColorId, obj);} );

            ReadGroupsProduct.ReadingGroupsProduct().ForEach( obj => {  MakeKey(obj); GroupsProductDic.Add(obj.GroupId, obj);} );

            ReadCartDetail.ReadingCartDetail().ForEach(obj =>
            {
                CartDetailDic.Add(new CartDetailKeys()
                {
                    CartId=obj.CartId,
                    ProductId=obj.ProductId,

                }, obj);
            });

            ReadCarts.ReadingCarts().ForEach( obj => {  MakeKey(obj); CartsDic.Add(obj.CartId, obj);} );

                
            #endregion


            var a = MemoryInfor.GetAllProducts();
        }
        
    }
}
