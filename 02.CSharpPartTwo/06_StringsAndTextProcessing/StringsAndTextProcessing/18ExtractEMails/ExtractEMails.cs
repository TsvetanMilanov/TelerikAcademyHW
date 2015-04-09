using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18ExtractEMails
{
    class ExtractEMails
    {
        static void Main(string[] args)
        {
            string inputString = "This is list of random e-mails: asdf@abv.bg, asdf_1@gmail.com, asdf_2@yahoo.com for testing the problem.";

            char[] separators = { ' ', ',' };

            string[] splittedString = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> mails = new List<string>();

            for (int i = 0; i < splittedString.GetLength(0); i++)
            {
                if (splittedString[i].Contains('@'))
                {
                    mails.Add(splittedString[i]);
                }
            }

            foreach (var mail in mails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
