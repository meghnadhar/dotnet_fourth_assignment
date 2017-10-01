using System;
using System.Collections.Generic;
using System.Linq;

namespace mainprogram
{
    public class ProductDetailsFill : IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
           ProductGroup pg1 = new ProductGroup()
           {
               ID = 1,
               Name = "Dairy"
           };

           ProductGroup pg2 = new ProductGroup()
           {
               ID = 2,
               Name = "Beverages"
           };

           ProductGroup pg3 = new ProductGroup()
           {
               ID = 3,
               Name = "Detergents"
           };

           ProductGroup pg4 = new ProductGroup()
           {
               ID = 4,
               Name = "Groceries"
           };
            List<ProductGroup> pGroup = new List<ProductGroup>(4);

           pGroup.Add(pg1);
           pGroup.Add(pg2);
           pGroup.Add(pg3);
           pGroup.Add(pg4);

           return pGroup;
        }

        public List<ProductInfo> ProductFill()
        {
           ProductInfo pi1 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 1,
               Name = "Go Cheese",
               Description = "Go Cheese 180g",
               rate = 115
           };

           ProductInfo pi2 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 2,
               Name = "Amul Cheese",
               Description = "Amul Cheese 210g",
               rate = 125
           }; 

           ProductInfo pi3 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 3,
               Name = "Britania Cheese",
               Description = "Britania Cheese 200g",
               rate = 100
           };

           ProductInfo pi4 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Beverages"),
               ID = 1,
               Name = "Coca-Cola",
               Description = "Coca-Cola 1 litre",
               rate = 60
           };
           
           ProductInfo pi5 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Beverages"),
               ID = 2,
               Name = "Sprite",
               Description = "Sprite 1 litre",
               rate = 70
           };

           ProductInfo pi6 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Detergents"),
               ID = 1,
               Name = "Surf Excel",
               Description = "Surf Excel 700gms",
               rate = 100
           };

           ProductInfo pi7 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Detergents"),
               ID = 2,
               Name = "Ariel",
               Description = "Ariel 1 kg",
               rate = 120
           };

           ProductInfo pi8 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Groceries"),
               ID = 1,
               Name = "Vegetables",
               Description = "Vegetables 2 kgs",
               rate = 200
           };

           ProductInfo pi9 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Groceries"),
               ID = 2,
               Name = "Spices",
               Description = "Spices 400gms",
               rate = 150
           };

           List<ProductInfo> pInfo = new List<ProductInfo>(9);

            pInfo.Add(pi1);
            pInfo.Add(pi2);
            pInfo.Add(pi3);
            pInfo.Add(pi4);
            pInfo.Add(pi5);
            pInfo.Add(pi6);
            pInfo.Add(pi7);
            pInfo.Add(pi8);
            pInfo.Add(pi9);

            return pInfo;
        }
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> pInfo)
        {
            ProductDetailsFill obj = new ProductDetailsFill();
            pInfo.Sort(obj);
            return pInfo;
        }
 public List<ProductInfo> ProductDelete1(List<ProductInfo> pInfo, int num)
        {    
            pInfo.RemoveAt(num);
            return pInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> pInfo)
        {
            pInfo.RemoveAll(item => item.rate>100);
            return pInfo;
        }

        public List<ProductInfo> ProductDelete3(List<ProductInfo> pInfo, int st, int end)
        {
            pInfo.RemoveRange(st,end);
            return pInfo;
        }
    }
}

