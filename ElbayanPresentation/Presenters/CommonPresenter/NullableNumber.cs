using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.CommonPresenter
{
    class NullableNumber
    {
        internal static long? BarecodeNumber(string BareCodeInupt)
        {
            long Barcode;
            return Int64.TryParse(BareCodeInupt, out Barcode) ? (long?)Barcode : null;
        }
        internal static int? ProductNumber(string ProductNumberInupt)
        {
            int ProductNumber;
            return Int32.TryParse(ProductNumberInupt, out ProductNumber) ? (int?)ProductNumber : null;
        }
    }
}
