using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string nullStr = null;
            Console.WriteLine(nullStr == null);
            Console.WriteLine(nullStr == string.Empty);
            Console.WriteLine(nullStr.Length);//reference exeption
            Console.WriteLine(string.Empty.Length);

            Console.ReadLine();
        }
    }
}
