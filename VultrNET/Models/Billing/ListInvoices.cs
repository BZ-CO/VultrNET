using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Billing
{
    public class ListInvoices
    {
        public ListInvoices(List<InvoiceWithBalance> invoices, Meta meta)
        {
            Invoices = invoices;
            Meta = meta;
        }

        [JsonPropertyName("billing_invoices")]
        public List<InvoiceWithBalance> Invoices { get; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; }
    }
}