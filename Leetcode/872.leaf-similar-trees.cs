/*
 * @lc app=leetcode id=872 lang=csharp
 *
 * [872] Leaf-Similar Trees
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var list1 = new List<int>();
        var list2 = new List<int>();

        void TravelTree(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                list.Add(node.val);
                return;
            }

            TravelTree(node.left, list);
            TravelTree(node.right, list);
        }

        TravelTree(root1, list1);
        TravelTree(root2, list2);

        if (list1.Count != list2.Count)
        {
            return false;
        }

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

