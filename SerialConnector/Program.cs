using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialConnector
{

    class Program
    {

        static void Main(string[] args)
        {

            var lst = new Listener("COM5", 9600);
            var ypr = new List<(float yaw, float pitch, float roll)>();
            lst.OnDataReceivedString = s =>
            {
                if (s.StartsWith("$"))
                {
                    var data = s.TrimStart('$').Split(';');
                    ypr.Add((float.Parse(data[0], CultureInfo.InvariantCulture), float.Parse(data[1], CultureInfo.InvariantCulture), float.Parse(data[2], CultureInfo.InvariantCulture)));

                    Console.WriteLine($"{ypr.Last()}");
                }
            };
            lst.StartAsync();


            //while (true)
            //{
            //    Console.Write($"request:");
            //    var inp = Console.ReadLine();
            //    lst.Write(inp);
            //    Console.WriteLine();
            //}


            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

       
    }
}
