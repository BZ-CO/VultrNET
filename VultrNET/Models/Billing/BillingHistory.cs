using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Billing
{
    public class BillingHistory
    {
        public BillingHistory(int id, DateTime date, string type, string description, decimal amount, decimal balance)
        {
            Id = id;
            Date = date;
            Type = type;
            Description = description;
            Amount = amount;
            Balance = balance;
        }

        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("date")] public DateTime Date { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("description")] public string Description { get; }

        [JsonPropertyName("amount")] public decimal Amount { get; }

        [JsonPropertyName("balance")] public decimal Balance { get; }
    }
}