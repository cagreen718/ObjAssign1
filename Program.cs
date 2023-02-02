using System;

namespace GameTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new Employee("Obando", "Rodrigo");
            Console.WriteLine(employee.FullName);
            Console.WriteLine(employee);
            employee.FirstName = "Antonio";
            Console.WriteLine(employee.FullName);
            Employee any = new Employee();
            Console.WriteLine(any.FullName);
        }
    }
}
