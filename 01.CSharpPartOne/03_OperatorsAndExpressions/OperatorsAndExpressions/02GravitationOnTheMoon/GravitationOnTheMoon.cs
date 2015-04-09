using System;

/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter the weight on earth: ");
        decimal weightOnEarth = decimal.Parse(Console.ReadLine());

        decimal weightOnTheMoon = weightOnEarth * 0.17M;

        Console.WriteLine("Weight on the Moon will be: {0}", weightOnTheMoon);
    }
}