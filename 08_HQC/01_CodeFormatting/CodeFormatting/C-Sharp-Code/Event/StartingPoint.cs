namespace Event
{
    using System;
    using System.Text;

    public class StartingPoint
    {
        private static EventHolder events = new EventHolder();

        public static void Main(string[] args)
        {
            bool keepProgramRunning = true;
            
            while (keepProgramRunning)
            {
                keepProgramRunning = ExecuteNextCommand();
            }

            StringBuilder output = Messages.GetOutPut();

            Console.WriteLine(output);
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            string countString = command.Substring(pipeIndex + 1);
            DateTime date = GetDate(command, "ListEvents");
            int count = int.Parse(countString);

            events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);

            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            dateAndTime = GetDate(commandForExecution, commandType);

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            /*
             * Try this input:
                A 01.01.2015
                A 01.01.2015
                A 01.01.2015
                A 01.01.2015
                L 01.01.2015|3
                E
             
             */

            string dateAsString = command.Split(new char[] { ' ', '|' })[1];

            DateTime date = DateTime.Parse(dateAsString);
            return date;
        }
    }
}
