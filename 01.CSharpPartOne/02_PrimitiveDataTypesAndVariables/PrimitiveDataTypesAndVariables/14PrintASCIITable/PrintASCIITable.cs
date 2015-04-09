using System;

/*Problem 14.* Print the ASCII Table

Find online more information about ASCII (American Standard Code for Information Interchange)
and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).*/

class PrintASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        char symbol;

        Console.WriteLine("ASCII table:\n");
        for (int i = 0; i <= 255; i++)
        {
            symbol = (char)i;
            Console.Write(symbol + "\t");
        }

        Console.WriteLine();
    }
}
