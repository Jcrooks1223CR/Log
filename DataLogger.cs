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


namespace LoggerCode
{
  public class DataLogger
  {
    public static void Main(string[] args)
    {
            string logData = File.ReadAllText(@".\logData.json");
            string logconfig = File.ReadAllText(@".\logconfig.json");
            LogDataFormat logDataFormat = new LogDataFormat();
            LogDataTransport logDataTransport = new LogDataTransport(); 
            
            



            /* if (string.IsNullOrEmpty(severity))
             {
                 return defaultLoggingLevel;
             }

             switch (severity.ToLower())
             {
                 case "critical":
                     return Critical;
                 case "error":
                     return Error;
                 case "warning":
                     return Warning;
                 case "information":
                     return Information;
                 case "verbose":
                     return Verbose;
                 default:
                     return defaultLoggingLevel;
             }*/

            void Log(string logData)
            {

            }
            void Error(logData)
            {
                if (!logData)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('error', logData);
                }

            }
            void Warn(logData)
            {
                if(!logData)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('warn', logData);
                }
            }

            void Info(logData)
            {
                if (!logData)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('info', logData);
                }
            }

            void Http(logData)
            {
                if(!logData)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('http', logData);
                }
            }

            void Verbose(logData)
            {
                if(!logData)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('verbose', logData);
                }
            }

            void Debug(logData)
            {
                if(!!logData.trace && !logData.data)
                {
                    Environment.Exit(0);
                    // write write bad request error to logger error log file
                }
                else
                {
                    // write write bad request error to logger error log file
                    this.log('debug', logData);
                }
            }

        }
  }
}