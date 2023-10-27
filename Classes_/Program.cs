using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "rumeysa";
            customer.LastName = "akkaya";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "Ankara", FirstName = "rum", LastName = "Demiroğ"
            };
            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
}
