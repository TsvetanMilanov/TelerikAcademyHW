using System;

/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
 * */
class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string[] cardSigns = new string[13];
        cardSigns[0] = "2";
        cardSigns[1] = "3";
        cardSigns[2] = "4";
        cardSigns[3] = "5";
        cardSigns[4] = "6";
        cardSigns[5] = "7";
        cardSigns[6] = "8";
        cardSigns[7] = "9";
        cardSigns[8] = "10";
        cardSigns[9] = "J";
        cardSigns[10] = "Q";
        cardSigns[11] = "K";
        cardSigns[12] = "A";

        bool isCard = false;

        Console.WriteLine("Enter card:");
        string card = Console.ReadLine();

        for (int i = 0; i < cardSigns.Length; i++)
        {
            if (cardSigns[i] == card)
            {
                isCard = true;
                break;
            }
        }

        if (isCard)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
