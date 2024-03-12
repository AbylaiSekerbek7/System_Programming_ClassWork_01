using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics; // Class Process

namespace ClassWork_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process runned with arg {0}", args.Length > 0 ? args[0] : "Empty");
            try
            {
                if (args.Length == 0 || args[0] == "0")
                {
                    Console.WriteLine("Process cycle exit");
                    return;
                }
                int cnt = int.Parse(args[0]) - 1;
                string name = Process.GetCurrentProcess().Modules[0].FileName; // Exe-file Name
                Process childPrc = Process.Start(name, cnt.ToString());
                childPrc.WaitForExit(); // waitining for execution
            }
            finally
            {
                Console.WriteLine("Good bye...");
                Console.ReadLine();
            }
        }
    }
}

