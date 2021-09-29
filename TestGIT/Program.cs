using System;

namespace TestGIT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Master Branch Changes");
            Employee.Name("ABC");

            Console.WriteLine("this is from Development branch check in");
            Console.ReadLine();
  
        }
    }
}
