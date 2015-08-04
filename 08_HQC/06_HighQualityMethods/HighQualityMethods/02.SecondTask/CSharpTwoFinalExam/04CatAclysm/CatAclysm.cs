namespace Cataclism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CatAclysm
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            CSharpConstructions constructions = new CSharpConstructions();
            string[] program = new string[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                program[i] = Console.ReadLine();
            }

            string joinedProgram = string.Join(string.Empty, program);

            for (int i = 0; i < joinedProgram.Length; i++)
            {
                char currentChar = joinedProgram[i];

                CheckChar(joinedProgram, currentChar, i, constructions);
            }

            Console.WriteLine(string.Join("\n", constructions.Methods));
        }

        private static void CheckChar(string joinedProgram, char currentChar, int index, CSharpConstructions constructions)
        {
            int tabsCount = 0;
            int tabIndex = 0;

            switch (currentChar)
            {
                case 's':
                    if (joinedProgram[index + 1] == 't' && joinedProgram[index + 2] == 'a' && joinedProgram[index + 3] == 't' && joinedProgram[index + 4] == 'i' && joinedProgram[index + 5] == 'c')
                    {
                        tabIndex = index;
                        tabsCount = 0;
                        while (joinedProgram[tabIndex] != '{')
                        {
                            if (joinedProgram[tabIndex] == ' ')
                            {
                                tabsCount++;
                            }

                            tabIndex++;
                        }

                        StringBuilder result = new StringBuilder();

                        string endBracket = string.Empty;
                        while (joinedProgram[index] != '\n' && (endBracket = joinedProgram.Substring(index + 1, tabsCount + 1)) == (new string('\t', tabsCount) + '{'))
                        {
                            result.Append(joinedProgram[index]);
                            index++;
                        }

                        constructions.AddMethod(result.ToString());
                    }

                    break;
            }
        }
    }
}