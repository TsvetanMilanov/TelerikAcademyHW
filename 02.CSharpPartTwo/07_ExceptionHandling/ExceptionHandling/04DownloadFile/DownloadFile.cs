using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

/*Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */

namespace _04DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting download...");
            WebClient webClient = new WebClient();
            string address = "http://telerikacademy.com/Content/Images/news-img01.png";
            string name = "news-img01.png";

            try
            {
                webClient.DownloadFile(address, name);
            }
            catch (ArgumentException argumentNullException)
            {
                Console.WriteLine(argumentNullException.Message);
            }
            catch (WebException webException)
            {
                Console.WriteLine(webException.Message);
            }
            catch (NotSupportedException notSupportedException)
            {
                Console.WriteLine(notSupportedException.Message);
            }
            finally
            {
                webClient.Dispose();
                Console.WriteLine("Good bye.");
            }


        }
    }
}
