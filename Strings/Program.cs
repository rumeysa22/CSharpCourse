using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string sentence = "my name is rumeysa akkaya";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is rüm";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("myname");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "_");
            var result13 = sentence.Remove(2,5);


            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "istanbul";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = " ankara";
            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
