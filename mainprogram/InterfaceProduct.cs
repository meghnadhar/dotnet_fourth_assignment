using System;
using System.Collections.Generic;

namespace mainprogram
{
    public interface IProduct
    {
        List<ProductGroup> ProductGroupFill();
        List<ProductInfo> ProductFill();
        IEnumerable<ProductInfo> ProductSort(List<ProductInfo> productinfo);
        List<ProductInfo> ProductDelete1(List<ProductInfo> productinfo, int num);
        List<ProductInfo> ProductDelete3(List<ProductInfo> productinfo, int st, int end);
        List<ProductInfo> ProductDelete4(List<ProductInfo> productinfo, string delete_name);
    }
}