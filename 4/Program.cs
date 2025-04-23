namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                TreeNode root = new TreeNode(9);
                root.Left = new TreeNode(6);
                root.Right = new TreeNode(15);
                root.Left.Left = new TreeNode(5);
                root.Left.Right = new TreeNode(8);
                root.Right.Left = new TreeNode(10);
                root.Right.Right = new TreeNode(16);
                Console.WriteLine("Най-малкият елемент в дървото е: " + BinarySearchTree.MinValue(root));
            }
        }
    }
}
