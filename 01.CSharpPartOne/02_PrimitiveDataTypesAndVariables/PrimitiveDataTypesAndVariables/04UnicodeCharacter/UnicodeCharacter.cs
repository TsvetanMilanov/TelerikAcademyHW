using System;

/*Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal)
using the \u00XX syntax, and then print it.*/

class UnicodeCharacter
{
    static void Main(string[] args)
    {
        char charVariable = '\u002A';
        Console.WriteLine(charVariable);
    }
}
