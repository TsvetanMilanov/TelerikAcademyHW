namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int n = 5;
            int m = 16;

            var shortestSequence = new List<int>();
            shortestSequence.Add(m);

            while (true)
            {
                int valueAfterDivision = m / 2;

                if (valueAfterDivision > n)
                {
                    m /= 2;
                    shortestSequence.Add(m);
                }
                else if (valueAfterDivision == n)
                {
                    m /= 2;
                    shortestSequence.Add(m);
                    break;
                }
                else
                {
                    int valueAfterSubstractingTwo = m - 2;

                    if (valueAfterSubstractingTwo > n)
                    {
                        m -= 2;
                        shortestSequence.Add(m);
                    }
                    else if (valueAfterSubstractingTwo == n)
                    {
                        m -= 2;
                        shortestSequence.Add(m);
                        break;
                    }
                    else
                    {
                        int valueAfterSubstractingOne = m - 1;

                        if (valueAfterSubstractingOne > n)
                        {
                            m -= 1;
                            shortestSequence.Add(m);
                        }
                        else if (valueAfterSubstractingOne == n)
                        {
                            m -= 1;
                            shortestSequence.Add(m);
                            break;
                        }
                    }
                }
            }

            shortestSequence.Reverse();

            Console.WriteLine("The shortest sequence is: ");
            Console.WriteLine(string.Join(", ", shortestSequence));
        }
    }
}
