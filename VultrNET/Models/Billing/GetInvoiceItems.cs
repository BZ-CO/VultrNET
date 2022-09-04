using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Billing
{
    public class GetInvoiceItems
    {
        public GetInvoiceItems(List<InvoiceItem> invoiceItems, Meta meta)
        {
            InvoiceItems = invoiceItems;
            Meta = meta;
        }

        [JsonPropertyName("invoice_items")] public List<InvoiceItem> InvoiceItems { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}