using System;
using System.Collections.Generic;
using System.Linq;

namespace mainprogram
{
    public class ProductDetailsFill : IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
           ProductGroup product_grp1 = new ProductGroup()
           {
               ID = 1,
               Name = "Dairy"
           };

           ProductGroup product_grp2 = new ProductGroup()
           {
               ID = 2,
               Name = "Beverages"
           };

           ProductGroup product_grp3 = new ProductGroup()
           {
               ID = 3,
               Name = "Detergents"
           };

           ProductGroup product_grp4 = new ProductGroup()
           {
               ID = 4,
               Name = "Groceries"
           };
            List<ProductGroup> productgroup = new List<ProductGroup>(4);

           productgroup.Add(product_grp1);
           productgroup.Add(product_grp2);
           productgroup.Add(product_grp3);
           productgroup.Add(product_grp4);

           return productgroup;
        }

        public List<ProductInfo> ProductFill()
        {
           ProductInfo product_item1 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 1,
               Name = "Go Cheese",
               Description = "Go Cheese 180g",
               rate = 115
           };

           ProductInfo product_item2 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 2,
               Name = "Amul Cheese",
               Description = "Amul Cheese 210g",
               rate = 125
           }; 

           ProductInfo product_item3 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 3,
               Name = "Britania Cheese",
               Description = "Britania Cheese 200g",
               rate = 100
           };

           ProductInfo product_item4 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Beverages"),
               ID = 1,
               Name = "Coca-Cola",
               Description = "Coca-Cola 1 litre",
               rate = 60
           };
           
           ProductInfo product_item5 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Beverages"),
               ID = 2,
               Name = "Sprite",
               Description = "Sprite 1 litre",
               rate = 70
           };

           ProductInfo product_item6 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Detergents"),
               ID = 1,
               Name = "Surf Excel",
               Description = "Surf Excel 700gms",
               rate = 100
           };

           ProductInfo product_item7 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Detergents"),
               ID = 2,
               Name = "Ariel",
               Description = "Ariel 1 kg",
               rate = 120
           };

           ProductInfo product_item8 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Groceries"),
               ID = 1,
               Name = "Vegetables",
               Description = "Vegetables 2 kgs",
               rate = 200
           };

           ProductInfo product_item9 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Groceries"),
               ID = 2,
               Name = "Spices",
               Description = "Spices 400gms",
               rate = 150
           };

           List<ProductInfo> productinfo = new List<ProductInfo>(9);

            productinfo.Add(product_item1);
            productinfo.Add(product_item2);
            productinfo.Add(product_item3);
            productinfo.Add(product_item4);
            productinfo.Add(product_item5);
            productinfo.Add(product_item6);
            productinfo.Add(product_item7);
            productinfo.Add(product_item8);
            productinfo.Add(product_item9);

            return productinfo;
        }
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> productinfo)
        {
            ProductDetailsFill obj = new ProductDetailsFill();
            productinfo.Sort(obj);
            return productinfo;
        }
        public List<ProductInfo> ProductDelete1(List<ProductInfo> productinfo, int num)
        {    
            productinfo.RemoveAt(num);
            return productinfo;
        }

       
        public List<ProductInfo> ProductDelete4(List<ProductInfo> productinfo, string delete_name)
       {
           
                   productinfo.RemoveAll(p =>p.Name==delete_name);
                   return productinfo;
        }

        public List<ProductInfo> ProductDelete3(List<ProductInfo> productinfo, int st, int end)
        {
            productinfo.RemoveRange(st,end);
            return productinfo;
        }
    }
}

