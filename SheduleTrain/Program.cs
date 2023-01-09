using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SheduleTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateData.Generate();
            Schedule newSchedule = GenerateData.scheduleFMCS;
            newSchedule.ToString();
            var result = newSchedule.Count("21");
            foreach (var i in result)
            {

                Console.Write(i.Key);
                Console.Write("  ");
                Console.Write(i.Value);
            }
        }
    }
}
