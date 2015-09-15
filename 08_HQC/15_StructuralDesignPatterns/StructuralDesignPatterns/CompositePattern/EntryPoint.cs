namespace CompositePattern
{
    public class EntryPoint
    {
        public static void Main()
        {
            UserInterfaceControl button = new Button();
            UserInterfaceControl border = new Border();
            UserInterfaceControl text = new Text();

            button.AddChild(text);
            border.AddChild(button);

            border.ShowOnDisplay(0);
        }
    }
}
