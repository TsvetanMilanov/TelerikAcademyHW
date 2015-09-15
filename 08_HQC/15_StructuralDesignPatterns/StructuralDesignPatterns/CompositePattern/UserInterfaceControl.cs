namespace CompositePattern
{
    using System;
    using System.Collections.Generic;

    public abstract class UserInterfaceControl
    {
        protected IList<UserInterfaceControl> children;

        public UserInterfaceControl(string type)
        {
            this.Type = type;
            this.children = new List<UserInterfaceControl>();
        }

        public string Type { get; set; }

        public abstract void AddChild(UserInterfaceControl insideControl);

        public abstract void RemoveChild(UserInterfaceControl insideControl);

        public abstract void ShowOnDisplay(int formatSpacesCount);
    }
}
