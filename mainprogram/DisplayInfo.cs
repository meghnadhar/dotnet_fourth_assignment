using System;
using System.Collections.Generic;
using System.Linq;

namespace mainprogram
{
    public class Display
    {
        public void displaySortedProducts()
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> pGroup = obj.ProductGroupFill();
                List<ProductInfo> pInfo = obj.ProductFill();
                IEnumerable<ProductInfo> p = obj.ProductSort(pInfo);

                foreach (ProductGroup item1 in pGroup)
                {
                    foreach (ProductInfo item2 in p)
                    {
                        if(item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAll()
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> pGroup = obj.ProductGroupFill();
                List<ProductInfo> pInfo = obj.ProductFill();

                foreach(ProductGroup item1 in pGroup)
                {
                    foreach(ProductInfo item2 in pInfo)
                    {
                        if(item1.ID == item2.GroupID)
                        {   
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }       
        }

        public void DisplayFound(string str)
        {
            if(str == null)
                Console.WriteLine("Please enter a string!");
            else    
            {
                try
                {
                    ProductDetailsFill obj = new ProductDetailsFill();

                    List<ProductGroup> pGroup = obj.ProductGroupFill();
                    List<ProductInfo> pInfo = obj.ProductFill();

                    var res = pInfo.Where(p => p.Name.ToUpper().Contains(str.ToUpper()));

                        foreach (ProductGroup item1 in pGroup)
                        {
                            foreach (ProductInfo item2 in res)
                            {
                                if (item1.ID == item2.GroupID)
                                {
                                    Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                                }
                            }   
                        }
                   
                }catch(Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }
                        
        }

        public void DisplayAfterDeletion1(int num)
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> pGroup = obj.ProductGroupFill();
                List<ProductInfo> pInfo = obj.ProductFill();

                List<ProductInfo> pNew = obj.ProductDelete1(pInfo,num);

                foreach (ProductGroup item1 in pGroup)
                {
                    foreach (ProductInfo item2 in pInfo)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }        
        }

        public void DisplayAfterDeletion2()
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> pGroup = obj.ProductGroupFill();
                List<ProductInfo> pInfo = obj.ProductFill();

                List<ProductInfo> pNew = obj.ProductDelete2(pInfo);

                foreach (ProductGroup item1 in pGroup)
                {
                    foreach (ProductInfo item2 in pInfo)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAfterDeletion3(int st, int end)
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> pGroup = obj.ProductGroupFill();
                List<ProductInfo> pInfo = obj.ProductFill();

                List<ProductInfo> pNew = obj.ProductDelete3(pInfo, st, end);

                foreach (ProductGroup item1 in pGroup)
                {
                    foreach (ProductInfo item2 in pInfo)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }
    }
}