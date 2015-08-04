namespace FirstTask
{
    using System;

    public class StartngPoint
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            Converter converter = new Converter();
            converter.ConvertBoolToString(true);
        }
    }
}
