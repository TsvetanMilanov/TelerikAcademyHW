namespace StringBuilderSubstring
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder inputStringBuilder, int index, int length)
        {
            string input = inputStringBuilder.ToString();

            StringBuilder result = new StringBuilder();

            result.Append(input.Substring(index, length));

            return result;
        }
    }
}
