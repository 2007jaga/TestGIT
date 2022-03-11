using System;

namespace TestGIT
{
    class Program
    {
        static void Main(string[] args)
        {

            Test.Create("English", "13/April/2022");
            Console.WriteLine("123654654 added one console file");
            
            Console.WriteLine("Testing");

            Employee.Name("ABC");

            Console.WriteLine("Development branch check in");
            Console.WriteLine("Here also changed");

            Console.WriteLine("Master Branch Changes");

 
            Console.WriteLine("Master Branch Changes"); 
            Console.WriteLine("Here changed Development branch check in");
            Student.Name("hari");
            Console.WriteLine("Here also changed");
            Console.ReadLine(); 
        }
    }
}
