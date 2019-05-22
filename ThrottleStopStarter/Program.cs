using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThrottleStopStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(2000);
            Process.Start(@"C:\Users\Martino\Documents\ThrottleStop\ThrottleStop.exe");
            Environment.Exit(-1);
        }
    }
}
