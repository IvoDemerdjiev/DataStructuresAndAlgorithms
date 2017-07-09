namespace CreatingTree.Tree
{
    using System;

    public class Tree<T> where T : IComparable<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        private int count;

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the root node</param>
        /// <param name="children">the children of the root
        /// node</param>
        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public TreeNode<T> Root
        {
            get { return this.root; }
        }

        /// <summary>
        /// Traverses and prints tree in Depth
        /// First Search (DFS) manner
        /// </summary>
        /// <param name="root">the root of the tree to be
        /// traversed</param>
        /// <param name="spaces">the spaces used for
        /// representation of the parent-child relation</param>
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary>
        /// Traverses and prints the tree in
        /// Depth First Search (DFS) manner
        /// </summary>
        public void PrintDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }

        public void FindOccurrences(TreeNode<T> root, int number)
        {
            if (this.root == null)
            {
                return;
            }

            TreeNode<T> child = null;

            for (var i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);

                var compareTo = number.CompareTo(child.Value);
                if (compareTo == 0)
                {
                    count++;
                }
                FindOccurrences(child, number);
            }
        }

        public void FindOccurrences(int number)
        {
            FindOccurrences(root, number);

            Console.WriteLine(count);
        }
    }

    public static class TreeExample
    {
        static void Main()
        {
            
        }
    }
}
