namespace RefactorChef
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private static void Peel(IPeelable vegetable)
        {
            // ...
        }

        private static Bowl GetBowl()
        {
            return new Bowl();
        }

        private static Carrot GetCarrot()
        {
            return new Carrot();
        }

        private static Potato GetPotato()
        {
            return new Potato();
        }

        private static void Cut(Vegetable potato)
        {
            // ...
        }
    }
}
