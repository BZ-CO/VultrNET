using System.Text.Json.Serialization;

namespace VultrNET.Models.Billing
{
    public class InvoiceWithBalance : Invoice
    {
        public InvoiceWithBalance(
            int id,
            string description,
            string date,
            decimal amount,
            decimal balance) : base(id, description, date, amount)
        {
            Balance = balance;
        }

        [JsonPropertyName("balance")] public decimal Balance { get; }
    }
}