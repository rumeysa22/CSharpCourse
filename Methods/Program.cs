﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3( number1 , number2); //değer tipini referans tip olarak kullanmamızı sağlar bu sayede işlemlerin sonunda değeri değişecektir ref yazılmasaydı ne olursa olsun en baştaki değerine geri dönüyordu 
            
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
