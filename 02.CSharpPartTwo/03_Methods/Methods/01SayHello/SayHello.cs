using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
 */

namespace _01SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        private static void PrintName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
