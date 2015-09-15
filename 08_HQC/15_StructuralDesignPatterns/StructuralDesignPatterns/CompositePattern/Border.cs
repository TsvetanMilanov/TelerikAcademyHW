using System;

namespace CompositePattern
{
    public class Border : UserInterfaceControl
    {
        public Border()
            : base("Border")
        {
        }

        public override void AddChild(UserInterfaceControl insideControl)
        {
            this.children.Add(insideControl);
        }

        public override void RemoveChild(UserInterfaceControl insideControl)
        {
            this.children.Remove(insideControl);
        }

        public override void ShowOnDisplay(int formatSpacesCount)
        {
            Console.Write(new string(' ', formatSpacesCount));
            Console.WriteLine("{0} with:", this.Type);

            foreach (var child in this.children)
            {
                child.ShowOnDisplay(formatSpacesCount + 4);
            }
        }
    }
}
