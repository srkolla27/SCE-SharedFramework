using System;
using System.Collections.Generic;
using System.Text;

namespace Telemetry.Models
{
    public class RequestTelemetry : BaseTelemetry
    {
        public string Name { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public bool IsSuccess { get; set; }
        public string RequestURL { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseCode { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
    }
}
