using System;

namespace CompositePattern
{
    public class Text : UserInterfaceControl
    {
        public Text()
            : base("Text")
        {
        }

        public override void AddChild(UserInterfaceControl insideControl)
        {
            Console.WriteLine("Can't add another user interface control to this control!");
        }

        public override void RemoveChild(UserInterfaceControl insideControl)
        {
            Console.WriteLine("Can't remove another user interface control from this control!");
        }

        public override void ShowOnDisplay(int formatSpacesCount)
        {
            Console.Write(new string(' ', formatSpacesCount));
            Console.WriteLine(this.Type);
        }
    }
}
