using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class EventTelemetry : BaseTelemetry
    {
        public string Name { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public Dictionary<string, double> Metrics { get; set; }
    }
}
