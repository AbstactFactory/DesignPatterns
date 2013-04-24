using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.bussiness
{
    public class Product : IProduct
    {
        public int Count { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public Guid Guid { get; set; }

        public override string ToString()
        {
            return String.Format("{0}   {1}   {2}   {3}\n", Name, Price, Count, Guid);
        }
    }
}
