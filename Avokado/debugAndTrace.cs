using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Avokado
{
    internal class debugAndTrace
    {
        public static void writeInFile(string action)
        {
            Debug.WriteLine("");
            Debug.WriteLine($"Действие: {action} ({DateTime.Now})");
            Trace.Flush();
        }

        public static void onStart()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
        }

        public static void writeInFile(string action, string[] data)
        {
            Debug.WriteLine("");
            Debug.WriteLine($"Действие: {action} ({DateTime.Now})");
            Debug.WriteLine("Используемые данные:");
            for (int i = 0; i < data.Length; i++)
            {
                if (i != data.Length - 1)
                {
                    Debug.WriteLine($"\t{data[i]};");
                }
                else
                {
                    Debug.WriteLine($"\t{data[i]}.");
                }
            }
            Trace.Flush();
        }
    }
}
