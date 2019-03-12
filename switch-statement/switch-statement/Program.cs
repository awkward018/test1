using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color =(Color) (new System.Random().Next(0, 3));
            Console.WriteLine(color);
            Console.Read();
        }
    }

    public enum Color { Red, Green, Blue}
    public class Random { } 
}
