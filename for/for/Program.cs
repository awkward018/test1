using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            int count = 0;
            int a = word.Length;
            for (int i = 0; i < a; i++)
            {
                if (word[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.Read();

        }
    }
}
