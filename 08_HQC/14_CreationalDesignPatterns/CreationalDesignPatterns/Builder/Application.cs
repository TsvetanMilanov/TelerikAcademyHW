namespace Builder
{
    using System.Text;

    public class Application
    {
        public string Design { get; set; }

        public string Code { get; set; }

        public int RanUnitTests { get; set; }

        public int BugsFixed { get; set; }

        public string GetApplicationInformation()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine("Application information:");
            information.AppendLine("Details about design of the application:");
            information.AppendLine(this.Design);
            information.AppendLine();
            information.AppendLine("Code of the application:");
            information.AppendLine(this.Code);
            information.AppendLine();
            information.AppendFormat("Unit test ran: {0} | Bugs fixed: {1}", this.RanUnitTests, this.BugsFixed);

            return information.ToString();
        }
    }
}
