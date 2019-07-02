using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class DependencyTelemetry : BaseTelemetry
    {
        public string DependencyName { get; set; }
        public string DependencyTypeName { get; set; }
        public bool IsSuccess { get; set; }
        public string CommandName { get; set; }
        public string ResponseCode { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string RequestUrl { get; set; }
        public string ResponseStatus { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
    }
}
