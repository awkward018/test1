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
            char[] str1 = @"\\server\file\file.txt".ToCharArray();

            string str2 = new string(str1);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
