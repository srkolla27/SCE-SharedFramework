using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class ExceptionTelemetry : BaseTelemetry
    {
        public Exception Exception { get; }
        public Dictionary<string, double> Metrics { get; set; }
        public string Category { get; set; }
    }
}
