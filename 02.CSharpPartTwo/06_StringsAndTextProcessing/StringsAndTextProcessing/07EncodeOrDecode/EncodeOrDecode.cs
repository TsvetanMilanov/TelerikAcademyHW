using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */

namespace _07EncodeOrDecode
{
    class EncodeOrDecode
    {
        static void Main(string[] args)
        {
            //For concole input:
            //Console.Write("Enter the string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the substring: ");
            //string subString = Console.ReadLine();

            string inputString = "This is the test string to be encoded and decoded.";

            string key = "asdf";

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(inputString);

            //Encode the string.
            stringBuilder = Encode(stringBuilder, key);

            Console.WriteLine("Encoded string:\n{0}", stringBuilder.ToString());

            //Decode the string.
            stringBuilder = Encode(stringBuilder, key);

            Console.WriteLine("\nDecoded string:\n{0}", stringBuilder.ToString());
        }

        private static StringBuilder Encode(StringBuilder stringBuilder, string key)
        {
            for (int i = 0, j = 0; i < stringBuilder.Length; i++, j++)
            {
                stringBuilder[i] ^= key[j];

                if (j == key.Length - 1)
                {
                    j = 0;
                }
            }
            return stringBuilder;
        }
    }
}
