using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }

            while (number >= 11);
            Console.ReadLine();
        }

        private static void  forLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished");
        }
    }
}
