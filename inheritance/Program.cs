using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Customer { FirstName = "rumeysa" }, new Student { FirstName = "amine" }, new Person { FirstName = "meva" }
        };
        foreach(var person in persons)
        {
            Console.WriteLine(person.FirstName);
        };
        
        Console.ReadLine();
        
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
