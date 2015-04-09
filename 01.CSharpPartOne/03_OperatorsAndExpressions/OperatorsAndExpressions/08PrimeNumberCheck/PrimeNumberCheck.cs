using System;

/*Problem 8. Prime Number Check

Write an expression that checks if given positive 
integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).*/

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        if (isPrime == true)
        {
            Console.WriteLine("(True) The number {0} IS prime.", number);
        }
        else
        {
            Console.WriteLine("(False) The number {0} is NOT prime.", number);
        }
    }
}
