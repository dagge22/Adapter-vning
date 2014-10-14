using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public interface IProduct
    {
        decimal IUnitPrice { get; set; }
        string IBarcode { get; set; }
        string ITitle { get; set; }
    }
}
