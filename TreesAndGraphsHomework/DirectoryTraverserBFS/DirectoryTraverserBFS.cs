namespace DirectoryTraverserBFS
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class DirectoryTraverserBFS
    {
        public static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue =
                  new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }

        static void Main(string[] args)
        {
            TraverseDir("C:\\ ");
        }
    }
}
