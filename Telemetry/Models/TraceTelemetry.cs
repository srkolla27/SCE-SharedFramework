using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Telemetry.Models
{
    public class TraceTelemetry : BaseTelemetry
    {
        public string Message;
        public Severity SeverityCode;
    }
}
