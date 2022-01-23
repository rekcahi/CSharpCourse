using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
                {
                    new Manager(),
                    new Worker(),
                    new Robot()
                };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            Console.WriteLine("Hello World!");
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
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void Salary()
        {
            Console.WriteLine("Manager Salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void Salary()
        {
            Console.WriteLine("Worker Salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work");
        }
    }
    class Robot : ISalary, IWorker
    {
        public void Salary()
        {
            Console.WriteLine("Robot Salary");
        }

        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
