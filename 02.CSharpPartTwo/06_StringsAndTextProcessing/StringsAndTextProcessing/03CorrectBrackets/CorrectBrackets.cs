using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
 */

namespace _03CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the expression");
            //string inputExpression = Console.ReadLine();

            string inputExpression = ")(a+b)/5-d)";

            int counterOpening = 0;
            int counterClosing = 0;

            for (int i = 0; i < inputExpression.Length; i++)
            {
                if (inputExpression[i] == '(')
                {
                    counterOpening++;
                }
                if (inputExpression[i] == ')')
                {
                    counterClosing++;
                }
            }

            if (counterOpening != counterClosing)
            {
                Console.WriteLine("The expression is incorrect.");
            }
            else
            {
                Console.WriteLine("The expression is correct.");
            }
        }
    }
}
