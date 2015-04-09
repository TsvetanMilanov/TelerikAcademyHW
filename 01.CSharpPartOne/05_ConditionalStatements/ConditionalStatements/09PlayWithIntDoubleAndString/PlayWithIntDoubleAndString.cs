using System;

/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter int number:");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber += 1;
                Console.WriteLine("The number is: {0}", intNumber);
                break;
            case 2:
                Console.WriteLine("Enter double number:");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber += 1;
                Console.WriteLine("The number is: {0}", doubleNumber);
                break;
            case 3:
                Console.WriteLine("Enter string:");
                string word = Console.ReadLine();
                word = word + '*';
                Console.WriteLine("The number is: {0}", word);
                break;
            default:
                Console.WriteLine("Not valid choice.");
                break;
        }
    }
}
