namespace TreeTask
{
    using System.Collections.Generic;

    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Children = new List<Node>();
        }

        public int Value { get; private set; }

        public List<Node> Children { get; private set; }

        public bool HasParent { get; set; }

        public void AddChild(Node child)
        {
            this.Children.Add(child);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Value, this.Children.Count);
        }
    }
}
