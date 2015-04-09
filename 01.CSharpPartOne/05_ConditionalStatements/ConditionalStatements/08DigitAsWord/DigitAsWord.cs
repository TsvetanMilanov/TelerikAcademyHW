using System;

/*Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
 */
class DigitAsword
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number between 0 and 9:");
        double number = double.Parse(Console.ReadLine());

        if ((number < 0) || (number > 9) || ((number % 1) != 0))
        {
            number = 123437;
        }

        switch ((int)number)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("Not a digit.");
                break;
        }
    }
}
