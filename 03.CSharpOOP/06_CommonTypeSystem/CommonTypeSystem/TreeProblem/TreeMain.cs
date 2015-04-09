namespace TreeProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TreeMain
    {
        public static void Main(string[] args)
        {
            TreeNode rootNode = new TreeNode(10);
            rootNode.Parent = null;

            BinarySearchTree tree = new BinarySearchTree(rootNode);

            TreeNode secondNode = new TreeNode(7);
            TreeNode thirdNode = new TreeNode(17);

            TreeNode fourthNode = new TreeNode(5);
            TreeNode fifthNode = new TreeNode(8);

            TreeNode sixthNode = new TreeNode(16);
            TreeNode seventhNode = new TreeNode(20);

            tree.AddElement(secondNode);
            tree.AddElement(thirdNode);
            tree.AddElement(fourthNode);
            tree.AddElement(fifthNode);
            tree.AddElement(sixthNode);
            tree.AddElement(seventhNode);

            Console.WriteLine("Print the tree with DFS algorithm:");
            PrintTreeDFS(tree.Root);

            Console.WriteLine("\nPrint the tree with BFS algorithm:");
            PrintTreeBFS(tree.Root);

            Console.WriteLine("\nSearch for node with value {0}:\n{1}", fourthNode.Value, tree.SearchElement(fourthNode));

            Console.WriteLine("\nForeach tree items:\n");
            foreach (var node in tree)
            {
                Console.WriteLine("===============================");
                Console.WriteLine(node.ToString());
                Console.WriteLine("===============================");
            }

            tree.DeleteElement(secondNode);
            Console.WriteLine("\nPrint the tree with DFS algorithm after removing element {0}:", secondNode.Value);
            PrintTreeDFS(tree.Root);
        }

        private static void PrintTreeBFS(TreeNode root)
        {
            if (root.Parent == null)
            {
                Console.WriteLine(root.Value);
            }

            if (root.LeftChild == null || root.RightChild == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.LeftChild.Value);
                Console.WriteLine(root.RightChild.Value);

                PrintTreeBFS(root.LeftChild);
                PrintTreeBFS(root.RightChild);
            }
        }

        private static void PrintTreeDFS(TreeNode root)
        {
            Console.WriteLine(root.Value);

            if (root.LeftChild == null || root.RightChild == null)
            {
                return;
            }
            else
            {
                PrintTreeDFS(root.LeftChild);
                PrintTreeDFS(root.RightChild);
            }
        }
    }
}
