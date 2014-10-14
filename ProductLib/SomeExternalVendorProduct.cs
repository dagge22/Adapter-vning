using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class SomeExternalVendorProduct
    {
        //public SomeExternalVendorProduct(SomeExternalVendorProduct someExternalVendorProduct)
        //{
        //    someExternalVendorProduct.Description = Description;
        //    someExternalVendorProduct.EANCode = EANCode;
        //    someExternalVendorProduct.PricePerUnit = PricePerUnit;
        //}
        public int PricePerUnit { get; set; }
        public string EANCode { get; set; }
        public string Description { get; set; }

    }
}
