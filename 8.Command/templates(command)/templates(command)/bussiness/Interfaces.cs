using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates
{
    public interface IProduct
    {
        Guid Guid { get; set; }

        int Price { get; set; }

        string Name { get; set; }
    }

    public interface IOrder
    {
        IList<IProduct> List { get; set; }

        void AddProduct(IProduct product);

        void RemoveProduct(IProduct product);

        int GetSumPrice();
    }
}
