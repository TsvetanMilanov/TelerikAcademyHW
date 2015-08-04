namespace RefactorStatements
{
    public class IfStatements
    {
        public static void Main(string[] args)
        {
            if (potato != null)
            {
                if (potato.HasBeenPeeled && potato.IsNotRotten)
                {
                    Cook(potato);
                }
            }

            bool yIsInRange = MAX_Y >= y && y >= MIN_Y;
            bool xIsInRange = MIN_X <= x && x <= MAX_X;

            if (xIsInRange && yIsInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
