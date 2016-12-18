using System;
using DbGenerate.Fashion;

namespace CreateDictionary.Memory
{
    public partial class MemoryInfor:Memory
    {
        public  static void MakeKey(BaseEntities be)
        {
            try
            {
				long maxId = 0;
                if (!KeyDic.ContainsKey(be.NameE()))
                {
                    KeyDic[be.NameE()] = 1;
                    return;
                }
                long.TryParse(KeyDic[be.NameE()].ToString(), out maxId);//chỉnh key cho phù hợp
				long maxKey = maxId + 1;

                if (be is Products)
                {
                    var entityUpdateKey = be as Products;
                    if (entityUpdateKey.ProductId <= 0 || entityUpdateKey.ProductId > maxId)
                    {
                        entityUpdateKey.ProductId = maxKey;
                        KeyDic[be.NameE()] = maxKey;
                    }

                }
                if (be is Colors)
                {
                    var entityUpdateKey = be as Colors;
                    if (entityUpdateKey.ColorId <= 0 || entityUpdateKey.ColorId > maxId)
                    {
                        entityUpdateKey.ColorId = maxKey;
                        KeyDic[be.NameE()] = maxKey;
                    }

                }
                if (be is GroupsProduct)
                {
                    var entityUpdateKey = be as GroupsProduct;
                    if (entityUpdateKey.GroupId <= 0 || entityUpdateKey.GroupId > maxId)
                    {
                        entityUpdateKey.GroupId = maxKey;
                        KeyDic[be.NameE()] = maxKey;
                    }

                }
                if (be is Carts)
                {
                    var entityUpdateKey = be as Carts;
                    if (entityUpdateKey.CartId <= 0 || entityUpdateKey.CartId > maxId)
                    {
                        entityUpdateKey.CartId = maxKey;
                        KeyDic[be.NameE()] = maxKey;
                    }

                }

            }
            catch (Exception)
            {
                bool isContain = KeyDic.ContainsKey(be.NameE());
                throw;
            }
        } 
    }
}
