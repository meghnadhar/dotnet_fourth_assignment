using System;
using System.Collections.Generic;

namespace mainprogram
{
    public interface IProduct
    {
        List<ProductGroup> ProductGroupFill();
        List<ProductInfo> ProductFill();
        IEnumerable<ProductInfo> ProductSort(List<ProductInfo> pInfo);
        List<ProductInfo> ProductDelete1(List<ProductInfo> pInfo, int num);
        List<ProductInfo> ProductDelete2(List<ProductInfo> pInfo);
        List<ProductInfo> ProductDelete3(List<ProductInfo> pInfo, int st, int end);
    }
}