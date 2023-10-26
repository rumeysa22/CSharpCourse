using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
          static void Main(string[] args)
          {
            //    string[] students = new string[] { "x", "y", "z" };

            //    string[] students2 = { "x", "y", "z" };
            //    students2[3] = "d";

            //    foreach (var student in students2)
            //    {
            //        Console.WriteLine(student);
            //    }


            string[,] regions = new string[4, 3]
            {
                 {"istanbul", "izmit", "bursa"},
                 {"ankara","konya", "krıkkale"},
                 { "Antalya", "adana", "Mersin"},
                 {"rize", "trabzon", "samsun"}

            };


          for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }
            Console.ReadLine();
          }
    }
}
