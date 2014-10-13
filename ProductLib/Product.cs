using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product : IProduct
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public string title { get; set; }

        public void ShowPrice()
        {
            throw new NotImplementedException();
        }
    }
}
