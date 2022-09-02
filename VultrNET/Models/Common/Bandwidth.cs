using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class Bandwidth
    {
        public Bandwidth(long incomingBytes, long outgoingBytes)
        {
            IncomingBytes = incomingBytes;
            OutgoingBytes = outgoingBytes;
        }

        [JsonPropertyName("incoming_bytes")] public long IncomingBytes { get; }

        [JsonPropertyName("outgoing_bytes")] public long OutgoingBytes { get; }
    }
}