using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.bussiness
{
    public class Order : IOrder
    {
        public IList<IProduct> List { get; set; }

        public void AddProduct(IProduct product)
        {
            List.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            List.Remove(product);
        }

        public int GetSumPrice()
        {
            return List.Sum(product => product.Price);
        }

        public override string ToString()
        {
            return List.Aggregate("", (current, product) => current + product.ToString());
        }
    }
}
