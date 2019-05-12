using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Tracing;

namespace Mantis.Automacao.tst.Helpers.ReportHelper
{
    class LogTraceListener : ITraceListener
    {

        static public string lastGherkinMessage;

        public void WriteTestOutput(string message)
        {
            lastGherkinMessage = message;

            Console.WriteLine(message);
        }

        public void WriteToolOutput(string message)
        {
            Console.WriteLine(message);
        }

    }
}
