using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsa.Activities.Kafka.Models
{
    public class MessageReceivedInput
    {
        public Dictionary<string, string>? MessageHeaders { get; set; }

        public string? MessageString { get; set; }

        public byte[]? MessageBytes { get; set; }
    }
}
