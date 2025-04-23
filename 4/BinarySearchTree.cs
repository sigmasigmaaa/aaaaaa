using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class BinarySearchTree
    {
        static void Inorder(TreeNode root, List<int> sortedInorder)
        {
            if (root == null) return;

            Inorder(root.Left, sortedInorder);

            sortedInorder.Add(root.Value);

            Inorder(root.Right, sortedInorder);
        }
        public static int MinValue(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            List<int> sortedInorder = new List<int>();
            Inorder(root, sortedInorder);
            return sortedInorder[0];
        }
    }
}
