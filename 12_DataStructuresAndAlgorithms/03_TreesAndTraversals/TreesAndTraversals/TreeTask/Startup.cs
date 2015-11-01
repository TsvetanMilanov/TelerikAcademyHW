namespace TreeTask
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<int, Node> nodes = ReadInput();

            Node root = FindRootNode(nodes);

            List<Node> leafs = FindLeafNodes(nodes);

            List<Node> middleNodes = FindMiddleNodes(nodes);

            int longestPath = FindLongestPath(root, 0);

            int sumInPath = 9;
            List<List<Node>> pathsWithSum = FindAllPathsWithSum(root, sumInPath);

            int sumForSubTree = 6;
            List<List<Node>> subTreesWithSum = FindAllSubTreesWithSum(root, sumForSubTree);

            Console.WriteLine("Root value: {0}", root.Value);
            Console.WriteLine("Leafs values: {0}", string.Join(", ", leafs.Select(l => l.Value)));
            Console.WriteLine("Middle nodes: {0}", string.Join(", ", middleNodes.Select(n => n.Value)));
            Console.WriteLine("Longest path: {0}", longestPath);
            Console.WriteLine("Paths with sum = {0}:", sumInPath);
            foreach (var path in pathsWithSum)
            {
                Console.WriteLine(string.Join(", ", path.Select(n => n.Value)));
            }

            Console.WriteLine("Subtrees with sum = {0}:", sumForSubTree);
            foreach (var subtree in subTreesWithSum)
            {
                Console.WriteLine(string.Join(", ", subtree.Select(n => n.Value)));
            }
        }

        private static List<List<Node>> FindAllSubTreesWithSum(Node root, int sumToFind)
        {
            var subTrees = new List<List<Node>>();

            subTrees.AddRange(FindSubTree(root, new List<Node>(), new List<Node>(), 0, sumToFind));

            var uniqueSubTrees = new HashSet<List<Node>>();

            foreach (var subtree in subTrees)
            {
                uniqueSubTrees.Add(subtree);
            }

            return subTrees;
        }

        private static IEnumerable<List<Node>> FindSubTree(
            Node root,
            List<Node> currentPath,
            List<Node> visitedLeafs,
            int currentSum,
            int sumToFind)
        {
            var result = new List<List<Node>>();

            if (root.Children.Count == 0)
            {
                if (currentPath.Count == 0)
                {
                    visitedLeafs.Add(root);
                }

                currentPath.Add(root);
                result.Add(currentPath);
                return result;
            }

            currentSum += root.Value;

            foreach (var child in root.Children)
            {
                var path = new List<Node>();
                path.AddRange(currentPath);
                path.Add(root);

                int nextSum = child.Value + currentSum;

                if (nextSum <= sumToFind)
                {
                    if (nextSum < sumToFind && child.Children.Count > 0 || nextSum == sumToFind)
                    {
                        result.AddRange(FindSubTree(child, path, visitedLeafs, currentSum, sumToFind));
                    }
                }

                if ((child.Children.Count != 0 || !visitedLeafs.Contains(child))
                    && (child.Children.Count != 0 || child.Value == sumToFind))
                {
                    result.AddRange(FindSubTree(child, new List<Node>(), visitedLeafs, 0, sumToFind));
                }
            }

            return result;
        }

        private static List<List<Node>> FindAllPathsWithSum(Node root, int sum)
        {
            List<List<Node>> paths = new List<List<Node>>();

            foreach (var child in root.Children)
            {
                paths.AddRange(CheckPath(child, new List<Node> { root, child }));
            }

            var result = paths
                .Where(p => p.Select(n => n.Value).Sum() == sum)
                .ToList();

            return result;
        }

        private static List<List<Node>> CheckPath(Node root, List<Node> currentPath)
        {
            if (root.Children.Count == 0)
            {
                return new List<List<Node>> { currentPath };
            }

            List<List<Node>> result = new List<List<Node>>();
            foreach (var child in root.Children)
            {
                var path = new List<Node>();
                path.AddRange(currentPath);
                path.Add(child);
                result.AddRange(CheckPath(child, path));
            }

            return result;
        }

        private static int FindLongestPath(Node root, int currentSum)
        {
            if (root.Children.Count == 0)
            {
                return currentSum;
            }

            int maxSum = 0;

            foreach (var child in root.Children)
            {
                maxSum = Math.Max(maxSum, FindLongestPath(child, currentSum + 1));
            }

            return maxSum;
        }

        private static List<Node> FindMiddleNodes(Dictionary<int, Node> nodes)
        {
            List<Node> middleNodes = new List<Node>();

            foreach (var pair in nodes)
            {
                var currentNode = pair.Value;

                if (currentNode.HasParent && currentNode.Children.Count > 0)
                {
                    middleNodes.Add(currentNode);
                }
            }

            return middleNodes;
        }

        private static List<Node> FindLeafNodes(Dictionary<int, Node> nodes)
        {
            List<Node> leafs = new List<Node>();

            foreach (var pair in nodes)
            {
                var currentNode = pair.Value;

                if (currentNode.Children.Count == 0)
                {
                    leafs.Add(currentNode);
                }
            }

            return leafs;
        }

        private static Node FindRootNode(Dictionary<int, Node> nodes)
        {
            foreach (var pair in nodes)
            {
                if (pair.Value.HasParent == false)
                {
                    return pair.Value;
                }
            }

            return null;
        }

        private static Dictionary<int, Node> ReadInput()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < n - 1; i++)
            {
                int[] values = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int parentValue = values[0];
                int childValue = values[1];

                Node parentNode;
                Node childNode = new Node(values[1]);

                if (nodes.ContainsKey(parentValue))
                {
                    parentNode = nodes[parentValue];
                }
                else
                {
                    parentNode = new Node(parentValue);
                    nodes.Add(parentValue, parentNode);
                }

                if (nodes.ContainsKey(childValue))
                {
                    childNode = nodes[childValue];
                }
                else
                {
                    childNode = new Node(childValue);
                    nodes.Add(childValue, childNode);
                }

                childNode.HasParent = true;

                parentNode.AddChild(childNode);
            }

            return nodes;
        }
    }
}
