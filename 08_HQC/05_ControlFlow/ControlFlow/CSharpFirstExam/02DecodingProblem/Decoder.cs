namespace Decode
{
    using System;

    public class Decoder
    {
        private const int NumberToAddIfLetter = 1000;
        private const int NumberToAddIfNumber = 500;
        private const int FinalTransformationNumber = 100;

        public static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string encodedText = Console.ReadLine();

            int currentPosition = 0;

            while (encodedText[currentPosition] != '@')
            {
                int currentSymbolsAsciiCode = (int)encodedText[currentPosition];

                decimal transformedCharacterCode =
                    DecodeCharacter(salt, currentPosition, currentSymbolsAsciiCode);

                PrintNumberInSpecificFormat(transformedCharacterCode);

                currentPosition++;
            }
        }

        private static decimal DecodeCharacter(int salt, int currentPosition, int charactersAsciiCode)
        {
            bool characterIsLetter = IsLetter(charactersAsciiCode);
            bool characterIsNumber = IsNumber(charactersAsciiCode);
            decimal transformedCharacterCode = 0m;

            if (characterIsLetter)
            {
                transformedCharacterCode = DecodeLetter(salt, charactersAsciiCode);
            }
            else if (characterIsNumber)
            {
                transformedCharacterCode = DecodeNumber(salt, charactersAsciiCode);
            }
            else
            {
                transformedCharacterCode = DecodeSpecialSymbol(salt, charactersAsciiCode);
            }

            if (currentPosition % 2 == 0)
            {
                transformedCharacterCode /= FinalTransformationNumber;
            }
            else
            {
                transformedCharacterCode *= FinalTransformationNumber;
            }

            return transformedCharacterCode;
        }

        private static decimal DecodeSpecialSymbol(int salt, int charactersAsciiCode)
        {
            decimal transformedCharacterCode = charactersAsciiCode;

            transformedCharacterCode -= salt;

            return transformedCharacterCode;
        }

        private static decimal DecodeNumber(int salt, int charactersAsciiCode)
        {
            decimal transformedCharacterCode = charactersAsciiCode;

            transformedCharacterCode += salt;
            transformedCharacterCode += FinalTransformationNumber;

            return transformedCharacterCode;
        }

        private static decimal DecodeLetter(int salt, int charactersAsciiCode)
        {
            decimal transformedCharacterCode = charactersAsciiCode;

            transformedCharacterCode *= salt;
            transformedCharacterCode += NumberToAddIfLetter;

            return transformedCharacterCode;
        }

        private static bool IsNumber(int characterCode)
        {
            bool isNumber = 48 <= characterCode && characterCode <= 57;

            return isNumber;
        }

        private static bool IsLetter(int characterCode)
        {
            bool isCapitalLetter = 65 <= characterCode && characterCode <= 90;
            bool isSmallLetter = 97 <= characterCode && characterCode <= 122;
            bool isLetter = isCapitalLetter || isSmallLetter;

            return isLetter;
        }

        private static void PrintNumberInSpecificFormat(decimal numberToPrint)
        {
            if (numberToPrint >= 0 && numberToPrint <= 99.99m)
            {
                Console.WriteLine("{0:F2}", numberToPrint);
            }
            else if (numberToPrint >= 100 && numberToPrint <= 999.99m)
            {
                Console.WriteLine("{0:F1}", numberToPrint);
            }
            else if (numberToPrint >= 1000)
            {
                Console.WriteLine("{0}", (int)numberToPrint);
            }
        }
    }
}