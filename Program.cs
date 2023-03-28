namespace HashTablesandBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------HashTables-------------");
            HashTables.PerformHashTables();
            BinarySearchTree output = new BinarySearchTree();
            output.Execute();
        }
    }
}