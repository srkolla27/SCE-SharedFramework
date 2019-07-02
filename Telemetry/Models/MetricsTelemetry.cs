using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class MetricsTelemetry : BaseTelemetry
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
