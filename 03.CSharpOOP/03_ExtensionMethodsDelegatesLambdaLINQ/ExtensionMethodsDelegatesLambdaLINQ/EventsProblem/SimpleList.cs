namespace EventsProblem
{
    using System;
    using System.Collections.Generic;

    public delegate void EventDelegate(object sender, EventArgs e);

    public class SimpleList
    {
        public SimpleList()
        {
            this.List = new List<int>();
        }

        public event EventDelegate SomeChange;

        public List<int> List { get; set; }

        public void AddNumber(int numberToAdd)
        {
            this.List.Add(numberToAdd);
            this.OnChange();
        }

        private void OnChange()
        {
            this.SomeChange(this, EventArgs.Empty);
        }
    }
}
