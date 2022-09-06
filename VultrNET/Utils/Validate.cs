using System;

namespace VultrNET.Utils
{
    public class Validate
    {
        public static void DNSRecordType(string type, string propName)
        {
            switch (type)
            {
                case "A":
                case "AAAAA":
                case "CNAME":
                case "NS":
                case "MX":
                case "SRV":
                case "TXT":
                case "CAA":
                case "SSHFP":
                    break;
                default:
                    throw new ArgumentOutOfRangeException(propName, type,
                        $"Invalid DNS record type {type}");
            }
        }
    }
}