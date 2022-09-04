using System.Text.Json.Serialization;

namespace VultrNET.Models.Billing
{
    public class Invoice
    {
        public Invoice(int id, string description, string date, decimal amount)
        {
            Id = id;
            Description = description;
            Date = date;
            Amount = amount;
        }

        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("description")] public string Description { get; }

        [JsonPropertyName("date")] public string Date { get; }

        [JsonPropertyName("amount")] public decimal Amount { get; }
    }
}