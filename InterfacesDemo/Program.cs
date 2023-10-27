using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3];
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2];
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker,IEat, ISalary
    {

    }

    class Worker : IWorker, IEat, ISalary
    {

    }

    class Robot : IWorker

    class Manager : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }
        public void Salary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        public void GetSalary()
        {
            throw new NotImplementedException();
        }
        public void work()
        {
            throw new NotImplementedException();
        }

        class Worker : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
            public void GetSalary()
            {
                throw new NotImplementedException();
            }
            public void work()
            {
                throw new NotImplementedException();
            }
        }
}