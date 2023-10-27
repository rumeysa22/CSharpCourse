using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
        };
        
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    static void Main(string[] args)
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "rumeysa",
            LastName = "akkaya",
            Address = "istanbul"
        };
        manager.Add(customer);
        manager.Add(student);
        Console.ReadLine();
    }
}

interface IPerson //interfacelerde temel amaç ana bir nesne olurşturmaktır ,
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}
class student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Depatment { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}

}
