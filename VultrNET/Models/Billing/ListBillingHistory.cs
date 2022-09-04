using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Billing
{
    public class ListBillingHistory
    {
        public ListBillingHistory(List<BillingHistory> billingHistory, Meta meta)
        {
            BillingHistory = billingHistory;
            Meta = meta;
        }

        [JsonPropertyName("billing_history")] public List<BillingHistory> BillingHistory { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}