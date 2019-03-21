using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -3;
            string city = "Minsk";
            DayOfWeek dt = DateTime.Now.DayOfWeek;
            string customMessage =$"It's {temperature} degrees, in {city} on this {dt}";
            Console.WriteLine(customMessage);
            Console.ReadLine();
        }
    }
}
