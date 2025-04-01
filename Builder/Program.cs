using Builder.Invoice;

Console.WriteLine("-------------------------------------------------------------------");

var invoice = new InvoiceBuilder()
	.SetInvoiceNumber("24125")
	.SetDate(new DateTime(2024, 1, 25))
	.SetVendor("Jan Kowalski")
	.SetVendee("Ryszard Kowalski")
	.SetNote("Note")
	.SetLineItems(new List<string> { "Line Item1", "LineItem2" })
	.Build();

Console.WriteLine(new InvoicePrinter(invoice).ToString());

Console.WriteLine("-------------------------------------------------------------------");