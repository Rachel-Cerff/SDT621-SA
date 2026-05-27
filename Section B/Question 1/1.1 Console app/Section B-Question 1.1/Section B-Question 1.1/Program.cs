using System;

namespace organizecode
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Hello " +  Name);

            Console.WriteLine("\nProgram Structure Demonstration:");
            Console.WriteLine("1. using System: imports functionality");
            Console.WriteLine("2. namespace: organizes code");
            Console.WriteLine("3. class Program: container for code");
            Console.WriteLine("4. Main(): entry point of program");
            Console.WriteLine("5. Comments: explain logic and documentation");

            Console.WriteLine("\nProgram executed successfully!");
        }
    }
}