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

                List<ProductGroup> productgroup = obj.ProductGroupFill();
                List<ProductInfo> productinfo = obj.ProductFill();
                IEnumerable<ProductInfo> p = obj.ProductSort(productinfo);

                foreach (ProductGroup item1 in productgroup)
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

                List<ProductGroup> productgroup = obj.ProductGroupFill();
                List<ProductInfo> productinfo = obj.ProductFill();

                foreach(ProductGroup item1 in productgroup)
                {
                    foreach(ProductInfo item2 in productinfo)
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

        public void DisplayFound(string str_keyword)
        {
            if(str_keyword == null)
                Console.WriteLine("Please enter a string!");
            else    
            {
                try
                {
                    ProductDetailsFill obj = new ProductDetailsFill();

                    List<ProductGroup> productgroup = obj.ProductGroupFill();
                    List<ProductInfo> productinfo= obj.ProductFill();

                    var res = productinfo.Where(p => p.Name.ToUpper().Contains(str_keyword.ToUpper()));

                        foreach (ProductGroup item1 in productgroup)
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

                List<ProductGroup> productgroup = obj.ProductGroupFill();
                List<ProductInfo> productinfo = obj.ProductFill();

                List<ProductInfo> pNew = obj.ProductDelete1(productinfo,num);

                foreach (ProductGroup item1 in productgroup)
                {
                    foreach (ProductInfo item2 in productinfo)
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

                List<ProductGroup> productgroup = obj.ProductGroupFill();
                List<ProductInfo> productinfo = obj.ProductFill();

                List<ProductInfo> pNew = obj.ProductDelete3(productinfo, st, end);

                foreach (ProductGroup item1 in productgroup)
                {
                    foreach (ProductInfo item2 in productinfo)
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
        public void DisplayAfterDeletion4(string delete_name)
        { try
             {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<ProductGroup> productgroup = obj.ProductGroupFill();
                List<ProductInfo> productinfo = obj.ProductFill();
                if(productinfo.Any(product=>product.Name==delete_name)){
                List<ProductInfo> pNew = obj.ProductDelete4(productinfo, delete_name);
                foreach (ProductGroup item1 in productgroup)
                {
                    foreach (ProductInfo item2 in productinfo)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }}
                else{Console.WriteLine("Enter a valid product name to be deleted");}

                
            }catch(Exception){
                Console.WriteLine("please enter valid input");
            }    
            
        }
       
    }
}