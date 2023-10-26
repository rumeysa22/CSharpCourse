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
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}

            //while (number >= 11);

            //string[] students = new string[3] { "rum", "ey", "sa" };
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();



        }

        if (IsPrimeNumber(6))
        { 
            Console.WriteLine("this is a prime  number");
        }
        else
        {
            Console.WriteLine("this is not a prime number");
        }
        Console.ReadLine();

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            
        }






        //private static void  forLoop()
        //{
        //    for (int i = 100; i >= 0; i = i - 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("finished");
        //}
    }
}
