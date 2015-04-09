using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */

namespace _12ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            //For console input:
            //string url = Console.ReadLine();

            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            string protocolSeparator = "://";

            int indexOfProtocolSeparator = url.IndexOf(protocolSeparator);

            string protocol = url.Substring(0, indexOfProtocolSeparator);

            int indexOfServerStart = indexOfProtocolSeparator + protocolSeparator.Length;

            char serverSeparator = '/';

            int indexOfServerSeparator = url.IndexOf(serverSeparator, indexOfServerStart);

            string server = url.Substring(indexOfServerStart, indexOfServerSeparator - indexOfServerStart);

            string resource = url.Substring(indexOfServerSeparator, url.Length - indexOfServerSeparator);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
