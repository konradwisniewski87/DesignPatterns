using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Invoice
{
	public class InvoicePrinter
	{
		private Invoice _invoice = default!;

		public InvoicePrinter(Invoice invoice)
        {
			_invoice = invoice;
		}
        public string ToString()
        {
            return $"Invoice number: {_invoice.Number}, vendor:  {_invoice.Vendor}, vendee: {_invoice.Vendee}, date: {_invoice.Date.ToString("dd-MM-yyyy")};";
        }

		public string ToJson()
		{
			return $"Invoice Json";
		}
    }
}
