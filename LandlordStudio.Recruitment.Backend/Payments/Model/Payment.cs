using System;
using System.Text.Json.Serialization;

namespace LandlordStudio.Recruitment.Backend.Payments.Model
{
    public class Payment
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("dueDate")]
        public DateTime DueDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }
    }
}
