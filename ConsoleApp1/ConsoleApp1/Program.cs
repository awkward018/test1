using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            int time = DateTime.Now.TimeOfDay.Hours;
            if (time > 9 && time < 12)
                Console.WriteLine("Good morning, Guys");
            else if (time > 12 && time < 15)
                Console.WriteLine("Good day, Guys");
            else if (time > 15 && time < 22)
                Console.WriteLine("Good evening, Guys");
            Console.ReadLine();

        }
    }
}
