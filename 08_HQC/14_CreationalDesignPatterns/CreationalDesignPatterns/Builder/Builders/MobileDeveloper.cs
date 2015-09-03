namespace Builder.Builders
{
    public class MobileDeveloper : Programmer
    {
        public override void DesignApplication()
        {
            this.Application.Design = "Used MVVM design pattern for the architecture of the application.";
        }

        public override void FixBugs()
        {
            this.Application.BugsFixed = 17;
        }

        public override void RunUnitTests()
        {
            this.Application.RanUnitTests = 100;
        }

        public override void WriteCode()
        {
            this.Application.Code = "public class MainActivity extends Activity {\n  @Override\n    protected void onCreate(Bundle savedInstanceState) {\n      super.onCreate(savedInstanceState);\n      setContentView(R.layout.main_activity_layout);\n  }\n}";
        }
    }
}
