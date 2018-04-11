namespace LeetCode.Easy
{
    /// <summary>
    /// 617. Merge Two Binary Trees
    /// Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.
    /// You need to merge them into a new binary tree.The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node.Otherwise, the NOT null node will be used as the node of new tree.
    /// </summary>
    public class Merge_Two_Binary_Trees
    {
        /// <summary>
        ///   Definition for a binary tree node.
        /// </summary>
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            return MergeTree(t1, t2);
        }

        private static TreeNode MergeTree(TreeNode t1, TreeNode t2)
        {
            TreeNode result = new TreeNode(1);

            if (t1 != null && t2 != null)
            {
                result.val = t1.val + t2.val;

                result.left = MergeTree(t1.left, t2.left);
                result.right = MergeTree(t1.right, t2.right);
            }
            else if (t1 != null && t2 == null)
            {
                result = t1;
            }
            else if (t1 == null && t2 != null)
            {
                result = t2;
            }
            else
            {
                result = null;
            }

            return result;
        }
    }
}
