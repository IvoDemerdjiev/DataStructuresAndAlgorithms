namespace OccurrencesOfANumberInATree
{
    using CreatingTree.Tree;

    internal class Occurrences
    {
        private static void Main(string[] args)
        {
            var tree =
                 new Tree<int>(7,
                       new Tree<int>(19,
                             new Tree<int>(1),
                             new Tree<int>(14),
                             new Tree<int>(31)),
                       new Tree<int>(21),
                       new Tree<int>(14,
                             new Tree<int>(14),
                             new Tree<int>(18))
                 );

            tree.PrintDFS();

            tree.FindOccurrences(14);
        }
    }
}
