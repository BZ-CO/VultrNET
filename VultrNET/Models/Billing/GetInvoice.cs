using System.Text.Json.Serialization;

namespace VultrNET.Models.Billing
{
    public class GetInvoice
    {
        public GetInvoice(Invoice invoice)
        {
            Invoice = invoice;
        }

        [JsonPropertyName("billing_invoice")] public Invoice Invoice { get; }
    }
}