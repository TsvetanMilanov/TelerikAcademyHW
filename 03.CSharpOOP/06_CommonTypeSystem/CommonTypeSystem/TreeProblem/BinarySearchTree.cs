namespace TreeProblem
{
    using System.Collections.Generic;

    public class BinarySearchTree : IEnumerable<TreeNode>
    {
        private List<TreeNode> listOfNodes;

        public BinarySearchTree(TreeNode rootNode)
        {
            this.Root = rootNode;
            this.listOfNodes = new List<TreeNode>();
        }

        public TreeNode Root { get; private set; }

        /// <summary>
        /// Add element to the tree.
        /// </summary>
        /// <param name="nodeToAdd">Node element.</param>
        public void AddElement(TreeNode nodeToAdd)
        {
            this.Root.AddChild(nodeToAdd);
        }

        public string SearchElement(TreeNode node)
        {
            string result = string.Empty;

            this.Root.SearchNode(node, ref result);

            return result;
        }

        public void DeleteElement(TreeNode node)
        {
            this.Root.DeleteChild(node);
        }

        public void DFS()
        {
            this.Root.ReturnNode(ref this.listOfNodes);
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            this.DFS();

            for (int i = 0; i < this.listOfNodes.Count; i++)
            {
                yield return this.listOfNodes[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            this.DFS();

            for (int i = 0; i < this.listOfNodes.Count; i++)
            {
                yield return this.listOfNodes[i];
            }
        }
    }
}
