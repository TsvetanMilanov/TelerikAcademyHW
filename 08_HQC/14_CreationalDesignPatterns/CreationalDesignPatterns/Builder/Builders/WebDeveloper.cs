namespace Builder.Builders
{
    public class WebDeveloper : Programmer
    {
        public override void DesignApplication()
        {
            this.Application.Design = "Used MVS design pattern for the architecture of the application";
        }

        public override void FixBugs()
        {
            this.Application.BugsFixed = 7;
        }

        public override void RunUnitTests()
        {
            this.Application.RanUnitTests = 42;
        }

        public override void WriteCode()
        {
            this.Application.Code = "<html>\n  <head>\n    <title>Some web application</title>\n  </head>\n  <body>\n    <!-- Content ... -->\n  </body>\n</html>";
        }
    }
}
