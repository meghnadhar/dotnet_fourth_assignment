using System;
using System.Collections.Generic;

namespace mainprogram
{
    public class FindGroupID
    {
        public static int Find(string str)
        {
            try
            {
                ProductDetailsFill pdf = new ProductDetailsFill();

                List<ProductGroup> PG = pdf.ProductGroupFill();

                foreach (ProductGroup item in PG)
                {
                    if(item.Name == "Dairy" && item.Name == str)
                        return 1;
                    if(item.Name == "Beverages" && item.Name == str)
                        return 2;
                    if(item.Name == "Detergents" && item.Name == str)
                        return 3;
                    if(item.Name == "Groceries" && item.Name == str)
                        return 4;
                }    
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}