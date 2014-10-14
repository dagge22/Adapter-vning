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
        private SomeExternalVendorProduct product = new SomeExternalVendorProduct();
        public void ShowPrice()
        {
            throw new NotImplementedException();
        }

        public decimal IUnitPrice
        {
            get
            {
                return product.PricePerUnit;
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
                return product.EANCode;
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
                return product.Description;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
