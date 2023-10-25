using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647; //32bit
            long number2 = -9223372036854775808;
            short number3 = 32767;
            byte number4 = 255;
            bool condition1 = false;
            char character = 'A';
            double number5 = 10.4; //64bit
            string city = "Ankara";
            decimal number6 = 10.4m;
            Console.WriteLine("number1 is {0}", number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine((int)Days.Wednesday);
            Console.ReadLine();
            Console.WriteLine("Character is : {0}", (int)character);
        } 
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
