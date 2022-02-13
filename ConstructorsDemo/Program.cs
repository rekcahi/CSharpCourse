using System;

namespace ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeManager employeeManager = new EmployeeManager(new DBLogger());
            //employeeManager.Add();

            Nested2 nested2 = new Nested2("a", "b", "c");
            Console.WriteLine("-------------------");
        }
    }
    interface ILogger
    {
        void Log();

    }
    class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("DB Logger");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logger");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;

        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!!");
        }
    }
}
