using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
using File = System.IO.File;
using LoggerCode.Core;

namespace LoggerCode.Model
{

    public class GetLogData2
    {
        public DateTime timeStamp { get; set; }

        public string host { get; set; }

        public string source { get; set; }

        public string correlationId { get; set; }

        public string code { get; set; }

        public string message { get; set; }

        public string http { get; set; }

        public string trace { get; set; }

        public List<string> data { get; set; }
    }
}