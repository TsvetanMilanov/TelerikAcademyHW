namespace TreeProblem
{
    using System.Collections.Generic;

    public class TreeNode
    {
        public TreeNode(int initialValue)
        {
            this.Value = initialValue;
        }

        public TreeNode(int initialValue, TreeNode leftNode, TreeNode rightNode)
            : this(initialValue)
        {
            this.Value = initialValue;
            this.LeftChild = leftNode;
            this.RightChild = rightNode;
        }

        public int Value { get; set; }

        public TreeNode Parent { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        /// <summary>
        /// Add child node to the parent node.
        /// </summary>
        /// <param name="nodeToAdd">Child node.</param>
        public void AddChild(TreeNode nodeToAdd)
        {
            /// Add to the left side.
            if (nodeToAdd.Value <= this.Value)
            {
                if (this.LeftChild == null)
                {
                    nodeToAdd.Parent = this;
                    this.LeftChild = nodeToAdd;
                }
                else
                {
                    this.LeftChild.AddChild(nodeToAdd);
                }
            }

            /// Add to the right side.
            if (nodeToAdd.Value > this.Value)
            {
                if (this.RightChild == null)
                {
                    nodeToAdd.Parent = this;
                    this.RightChild = nodeToAdd;
                }
                else
                {
                    this.RightChild.AddChild(nodeToAdd);
                }
            }
        }

        public void SearchNode(TreeNode node, ref string result)
        {
            if (this.Value == node.Value)
            {
                result = string.Format("Found item with value {0}, with parent's value {1}.", node.Value, this.Parent.Value);
            }

            if (this.LeftChild == null || this.RightChild == null || result != string.Empty)
            {
                return;
            }

            this.LeftChild.SearchNode(node, ref result);
            this.RightChild.SearchNode(node, ref result);
        }

        public override string ToString()
        {
            if (this.LeftChild == null || this.RightChild == null)
            {
                return string.Format("Value: {0}", this.Value);
            }
            else
            {
                return string.Format("Value: {0}\nLeft child value: {1}\nRight child value: {2}", this.Value, this.LeftChild.Value, this.RightChild.Value);
            }
        }

        internal void DeleteChild(TreeNode node)
        {
            if (this.LeftChild == null || this.RightChild == null)
            {
                return;
            }

            if (node.Value == this.Value)
            {
                this.LeftChild = null;
                this.RightChild = null;
                return;
            }

            this.LeftChild.DeleteChild(node);
            this.RightChild.DeleteChild(node);
        }

        internal TreeNode ReturnNode(ref List<TreeNode> listOfNodes)
        {
            listOfNodes.Add(this);

            if (this.LeftChild != null || this.RightChild != null)
            {
                this.LeftChild.ReturnNode(ref listOfNodes);
                this.RightChild.ReturnNode(ref listOfNodes);
            }

            return null;
        }
    }
}
