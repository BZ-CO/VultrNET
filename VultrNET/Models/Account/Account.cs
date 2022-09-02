using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Account
{
    public class Account
    {
        public Account(
            string name,
            string email,
            List<string> acls,
            decimal balance,
            decimal pendingCharges,
            DateTime lastPaymentDate,
            decimal lastPaymentAmount)
        {
            Name = name;
            Email = email;
            Acls = acls;
            Balance = balance;
            PendingCharges = pendingCharges;
            LastPaymentDate = lastPaymentDate;
            LastPaymentAmount = lastPaymentAmount;
        }

        [JsonPropertyName("name")] public string Name { get; }

        [JsonPropertyName("email")] public string Email { get; }

        [JsonPropertyName("acls")] public List<string> Acls { get; }

        [JsonPropertyName("balance")] public decimal Balance { get; }

        [JsonPropertyName("pending_charges")] public decimal PendingCharges { get; }

        [JsonPropertyName("last_payment_date")]
        public DateTime LastPaymentDate { get; }

        [JsonPropertyName("last_payment_amount")]
        public decimal LastPaymentAmount { get; }
    }
}