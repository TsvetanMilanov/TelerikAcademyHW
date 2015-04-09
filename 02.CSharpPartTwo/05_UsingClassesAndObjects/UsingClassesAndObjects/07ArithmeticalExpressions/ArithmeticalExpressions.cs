using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7.* Arithmetical expressions

Write a program that calculates the value of given arithmetical expression.
The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities): (, )
 */

namespace _07ArithmeticalExpressions
{
    class ArithmeticalExpressions
    {
        static char[] operators = { '+', '-', '*', '/' };

        static string[] functions = { "ln", "pow", "sqrt" };

        static void Main(string[] args)
        {
            //For console input:
            //string expression = Console.ReadLine();

            string expression = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";

            //string expression = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";

            //Remove whiteSpaces in the input expression.
            expression = expression.Replace(" ", string.Empty);
            expression = expression.ToLower();

            try
            {
                //Make the sequence of symbols.
                var allSymbols = GetAllSymbols(expression);

                var rpn = ConvertToRPN(allSymbols);

                var answer = CalculateRPN(rpn);

                Console.WriteLine("{0} = {1}", expression, answer);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static List<string> GetAllSymbols(string expression)
        {
            List<string> result = new List<string>();

            StringBuilder number = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '-' && (i == 0 || expression[i - 1] == ',' || expression[i - 1] == '('))
                {
                    number.Append('-');
                }
                else if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    number.Append(expression[i]);
                }
                else if (!char.IsDigit(expression[i]) && expression[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());

                    number.Clear();

                    i--;
                }
                else if (expression[i] == '(')
                {
                    result.Add(expression[i].ToString());
                }
                else if (expression[i] == ')')
                {
                    result.Add(expression[i].ToString());
                }
                else if (operators.Contains(expression[i]))
                {
                    result.Add(expression[i].ToString());
                }
                else if (expression[i] == ',')
                {
                    result.Add(expression[i].ToString());
                }
                else if ((i + 1 < expression.Length) && (expression.Substring(i, 2) == "ln"))
                {
                    result.Add("ln");
                    i++;
                }
                else if ((i + 2 < expression.Length) && (expression.Substring(i, 3) == "pow"))
                {
                    result.Add("pow");
                    i += 2;
                }
                else if ((i + 3 < expression.Length) && (expression.Substring(i, 4) == "sqrt"))
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression!!!");
                }
            }

            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }

        static Queue<string> ConvertToRPN(List<string> allSymbols)
        {
            Stack<string> stack = new Stack<string>();

            Queue<string> queue = new Queue<string>();


            double number;
            for (int i = 0; i < allSymbols.Count; i++)
            {
                var currentSymbol = allSymbols[i];

                if (double.TryParse(currentSymbol, out number))
                {
                    queue.Enqueue(currentSymbol);
                }
                else if (functions.Contains(currentSymbol))
                {
                    stack.Push(currentSymbol);
                }
                else if (currentSymbol == ",")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid function syntax.");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (operators.Contains(currentSymbol[0]))
                {
                    while (stack.Count != 0 && operators.Contains(stack.Peek()[0]) && (Priority(currentSymbol) <= Priority(stack.Peek())))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Push(currentSymbol);
                }
                else if (currentSymbol == "(")
                {
                    stack.Push(currentSymbol);
                }
                else if (currentSymbol == ")")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid use of paretheses.");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Pop();

                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (stack.Peek() == "(" || stack.Peek() == ")")
                {
                    throw new ArgumentException("Invalid parenthesis use #2.");
                }
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        static double CalculateRPN(Queue<string> queue)
        {
            double result = 0;

            Stack<double> stack = new Stack<double>();

            string currentSymbol = string.Empty;

            double firstNumber = 0;
            double secondNumber = 0;

            int i = 0;
            while (queue.Count != 0)
            {
                currentSymbol = queue.Dequeue();

                double number;


                if (double.TryParse(currentSymbol, out number))
                {
                    stack.Push(number);
                    i++;
                }
                else if (operators.Contains(currentSymbol[0]) || functions.Contains(currentSymbol))
                {
                    if (currentSymbol == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();
                            secondNumber = stack.Pop();

                            stack.Push(firstNumber + secondNumber);
                            i++;
                    }
                    else if (currentSymbol == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();
                            secondNumber = stack.Pop();

                            stack.Push(secondNumber - firstNumber);
                            i++;
                    }
                    else if (currentSymbol == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();
                            secondNumber = stack.Pop();

                            stack.Push(firstNumber * secondNumber);
                            i++;
                    }
                    else if (currentSymbol == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();
                            secondNumber = stack.Pop();

                            stack.Push(secondNumber / firstNumber);
                            i++;
                    }
                    else if (currentSymbol == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();
                            secondNumber = stack.Pop();

                            stack.Push(Math.Pow(secondNumber, firstNumber));
                            i++;
                    }
                    else if (currentSymbol == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();

                            stack.Push(Math.Sqrt(firstNumber));
                            i++;
                    }
                    else if (currentSymbol == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expresiion.");
                        }
                            firstNumber = stack.Pop();

                            stack.Push(Math.Log(firstNumber));
                            i++;
                    }
                }

            }
            if (stack.Count == 1)
            {
                result = stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression.");
            }
            return result;
        }

        static int Priority(string currentOperator)
        {
            if (currentOperator == "+" || currentOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}