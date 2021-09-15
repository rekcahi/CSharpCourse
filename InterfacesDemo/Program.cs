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
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : ISalary, IWorker
    {
        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
