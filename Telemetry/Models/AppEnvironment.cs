using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class AppEnvironment
    {
        public string ServiceOfferingName { get; set; }
        public string ServiceLineName { get; set; }
        public string ServiceName { get; set; }
        public string ComponentName { get; set; }
        public string EnvironmentName { get; set; }
        public string ComponentId { get; set; }
        public string IctoId { get; set; }
    }
}
