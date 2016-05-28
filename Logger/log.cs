using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Logger
{
    public class Logger
    {
        LogDelegate _method;

        public Logger(LogDelegate method)
        {
            _method = method;
        }

        public void LogError(string message)
        {
            _method(DateTime.Now + " Error: " + message);
        }

        public void LogDebug(string message)
        {
            _method(DateTime.Now + " Debug: " + message);
        }

        public void LogWarning(string message)
        {
            _method(DateTime.Now + " Warning: " + message);
        }

        public void LogInfo(string message)
        {
            _method(DateTime.Now + " Info: " + message);
        }
    }

    public delegate void LogDelegate(string message);
}