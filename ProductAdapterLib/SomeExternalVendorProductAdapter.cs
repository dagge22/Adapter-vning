using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public string Title { get; set; }

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)
        {
            Price = someExternalVendorProduct.PricePerUnit;
            Barcode = someExternalVendorProduct.EANCode;
            Title = someExternalVendorProduct.Description;
        }

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
    }
}
