namespace Builder
{
    using System;
    using Builders;
    using Directors;

    public class BuilderEntryPoint
    {
        public static void Main(string[] args)
        {
            Director teamLeader = new TeamLeader();

            Programmer webDeveloper = new WebDeveloper();

            Application webApplication = teamLeader.CreateApplication(webDeveloper);

            Console.WriteLine("Created Web Application:");
            Console.WriteLine(webApplication.GetApplicationInformation());

            Programmer mobileDeveloper = new MobileDeveloper();

            Application mobileApplication = teamLeader.CreateApplication(mobileDeveloper);

            Console.WriteLine("\n\nCreated Mobile Application:");
            Console.WriteLine(mobileApplication.GetApplicationInformation());
        }
    }
}
