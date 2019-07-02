using System;
using System.Collections.Generic;

namespace Telemetry.Models
{
    public class BaseTelemetry
    {
        //Check on the use case of this tuple
        public Dictionary<string, ValueTuple> Properties { get; set; }
        public string EventId { get; set; }
        public dynamic DataObject { get; set; }
        public string CorrelationId { get; set; }
        public string FrameworkVersion { get; set; }
        public AppEnvironment ServiceDetails { get; set; }
    }

    public enum Severity
    {
        Verbose = 0,
        Information = 1,
        Warning = 2,
        Error = 3,
        Critical = 4,
    }
}
