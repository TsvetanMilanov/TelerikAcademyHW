using System;

/*Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */
class PrintADeckOfCards
{
    static void Main(string[] args)
    {
        string card = "";
        string[] cardSuite = { "spades", "clubs", "hearts", "diamonds" };

        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    card = Convert.ToString(i);
                    break;
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default:
                    Console.WriteLine("Not a valid card.");
                    break;
            }
            for (int j = 0; j <= 3; j++)
            {
                if (j == 3)
                {
                    Console.Write("{0,2} of {1} ", card, cardSuite[j]);
                    continue;
                }
                Console.Write("{0,3} of {1}, ", card, cardSuite[j]);
            }
            Console.WriteLine();
        }
    }
}
