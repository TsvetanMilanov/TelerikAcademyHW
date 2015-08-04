namespace Draw
{
    using System;

    class PersianRugsDrawer
    {
        private const string RugsCenterSymbol = "X";
        private const char RugsSideFillingSymbol = '#';
        private const char RugsRightSewSymbol = '/';
        private const char RugsLeftSewSymbol = '\\';

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int height = (2 * n) + 1;
            int width = (2 * n) + 1;

            if (d > ((width - 4) / 2))
            {

                int middleSpacesCount = width - 2;
                int bottomDiEsCount = width / 2 - 1;

                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string(RugsSideFillingSymbol, i));
                    Console.Write(RugsLeftSewSymbol);
                    Console.Write(new string(' ', middleSpacesCount));
                    Console.Write(RugsRightSewSymbol);
                    Console.Write(new string(RugsSideFillingSymbol, i));


                    Console.WriteLine();


                    if (middleSpacesCount <= 1)
                    {
                        continue;
                    }
                    middleSpacesCount = middleSpacesCount - 2;
                }

                Console.Write(new string(RugsSideFillingSymbol, n));
                Console.Write(RugsCenterSymbol);
                Console.Write(new string(RugsSideFillingSymbol, n));

                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string(RugsSideFillingSymbol, bottomDiEsCount));
                    Console.Write(RugsRightSewSymbol);
                    Console.Write(new string(' ', middleSpacesCount));
                    Console.Write(RugsLeftSewSymbol);
                    Console.Write(new string(RugsSideFillingSymbol, bottomDiEsCount));


                    Console.WriteLine();

                    bottomDiEsCount--;

                    middleSpacesCount = middleSpacesCount + 2;
                }
            }
            else
            {

                int middleSpacesCount = 0;
                int bottomDiEsCount = width / 2 - 1;
                int counterSpaces = width - 2;

                int smallDotsCount = width - 4 - 2 * d;
                int smallDashCount = 1;
                int spacesD = d;
                int flag = 0;

                for (int i = 0; i < n; i++)
                {
                    if (smallDotsCount < 0)
                    {
                        smallDotsCount = 1;
                    }
                    if (flag == 1)
                    {
                        if (middleSpacesCount > 0)
                        {

                            middleSpacesCount -= 2;
                        }
                    }
                    Console.Write(new string(RugsSideFillingSymbol, i));
                    Console.Write(RugsLeftSewSymbol);
                    Console.Write(new string(' ', middleSpacesCount + d));

                    if (smallDashCount == 0)
                    {
                        Console.Write(new string(' ', 1));
                    }
                    Console.Write(new string(RugsLeftSewSymbol, smallDashCount));
                    Console.Write(new string('.', smallDotsCount));
                    Console.Write(new string(RugsRightSewSymbol, smallDashCount));
                    Console.Write(new string(' ', middleSpacesCount + d));
                    Console.Write(RugsRightSewSymbol);
                    Console.Write(new string(RugsSideFillingSymbol, i));


                    Console.WriteLine();
                    if (smallDotsCount >= 1)
                    {
                        smallDotsCount -= 2;
                    }

                    if (smallDotsCount <= 0)
                    {
                        smallDashCount = 0;
                        smallDotsCount = 0;
                        if (flag == 1)
                        {
                            continue;
                        }
                        middleSpacesCount = d;
                        flag = 1;
                    }

                    //if (middleSpaces <= 0)
                    //{
                    //    continue;
                    //}
                    //middleSpaces -= 2;
                }

                Console.Write(new string(RugsSideFillingSymbol, n));
                Console.Write(RugsCenterSymbol);
                Console.Write(new string(RugsSideFillingSymbol, n));

                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string(RugsSideFillingSymbol, bottomDiEsCount));
                    Console.Write(RugsRightSewSymbol);
                    Console.Write(new string(' ', middleSpacesCount));
                    Console.Write(RugsLeftSewSymbol);
                    Console.Write(new string(RugsSideFillingSymbol, bottomDiEsCount));


                    Console.WriteLine();

                    bottomDiEsCount--;

                    middleSpacesCount = middleSpacesCount + 2;
                }
            }
        }
    }

}