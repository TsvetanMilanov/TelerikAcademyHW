using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

/*Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */

namespace _03ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to the file and file name (e.g. C:\\WINDOWS\\win.ini): ");
            string path = Console.ReadLine();

            try
            {
                string result = File.ReadAllText(path);
            }
            catch (ArgumentNullException argumentNullException)
            {
                Console.WriteLine(argumentNullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
            catch (PathTooLongException pathTooLongException)
            {
                Console.WriteLine(pathTooLongException.Message);
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                Console.WriteLine(directoryNotFoundException.Message);
            }
            catch (FileNotFoundException fileNotFoundException)
            {
                Console.WriteLine(fileNotFoundException.Message);
            }
            catch (IOException ioException)
            {
                Console.WriteLine(ioException.Message);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                Console.WriteLine(unauthorizedAccessException.Message);
            }
            catch (NotSupportedException notSupportedException)
            {
                Console.WriteLine(notSupportedException.Message);
            }
            catch (SecurityException securityException)
            {
                Console.WriteLine(securityException.Message);
            }
        }
    }
}
