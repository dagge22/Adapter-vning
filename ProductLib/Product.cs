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
                return 10;
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
                return "barcode";
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
                return "title";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
