using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ThrottleStopStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ThrottleStop\\ThrottleStop.exe");
            Thread.Sleep(2000);
            Process.Start(path);
            Environment.Exit(-1);
        }
    }
}
