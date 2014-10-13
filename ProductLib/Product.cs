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
        public string Title { get; set; }


        public decimal IUnitPrice
        {
            get
            {
                return Price;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string IBarcode
        {
            get
            {
                return Barcode;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ITitle
        {
            get
            {
                return Title;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ShowPrice()
        {
            throw new NotImplementedException();
        }
    }
}
