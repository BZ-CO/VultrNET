using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Billing
{
    public class InvoiceItem
    {
        public InvoiceItem(
            string description,
            string product,
            DateTime startDate,
            DateTime endDate,
            int units,
            string unitType,
            double unitPrice,
            double total)
        {
            Description = description;
            Product = product;
            StartDate = startDate;
            EndDate = endDate;
            Units = units;
            UnitType = unitType;
            UnitPrice = unitPrice;
            Total = total;
        }

        [JsonPropertyName("description")] public string Description { get; }

        [JsonPropertyName("product")] public string Product { get; }

        [JsonPropertyName("start_date")] public DateTime StartDate { get; }

        [JsonPropertyName("end_date")] public DateTime EndDate { get; }

        [JsonPropertyName("units")] public int Units { get; }

        [JsonPropertyName("unit_type")] public string UnitType { get; }

        [JsonPropertyName("unit_price")] public double UnitPrice { get; }

        [JsonPropertyName("total")] public double Total { get; }
    }
}