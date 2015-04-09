using System;

/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©*/

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        char symbol = '\u00a9';

        int number = 9;
        int middleSpace = 1;
        int size = (int)Math.Sqrt(number);

        for (int i = 0; i <= size; i++)
        {
            if (i == 0)
            {
                Console.Write(new String(' ', size + 1));
                Console.Write(symbol);
                Console.WriteLine();
            }
            else if (i < size)
            {

                Console.Write(new String(' ', (size + 1) - i));
                Console.Write(symbol);
                Console.Write(new String(' ', middleSpace));
                Console.Write(symbol);
                Console.WriteLine();
                middleSpace += 2;

            }
            else
            {
                for (int j = 0; j <=size; j++)
                {
                    Console.Write(" ");
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

    }
}
