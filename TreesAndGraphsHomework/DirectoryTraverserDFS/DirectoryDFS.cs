namespace DirectoryTraverserDFS
{
    using System;
    using System.IO;


    internal class DirectoryDFS
    {
        public static class DirectoryTraverserDFS
        {
            private static void TraverseDir(DirectoryInfo dir,
                string spaces)
            {
                // Visit the current directory
                Console.WriteLine(spaces + dir.FullName);

                DirectoryInfo[] children = dir.GetDirectories();

                // For each child go and visit its subtree
                foreach (DirectoryInfo child in children)
                {
                    TraverseDir(child, spaces + "  ");
                }
            }

            public static void TraverseDir(string directoryPath)
            {
                TraverseDir(new DirectoryInfo(directoryPath),
                    string.Empty);
            }

            private static void Main()
            {
                TraverseDir("C:\\");
            }
        }
    }
}
