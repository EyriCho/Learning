/*
 * @lc app=leetcode id=1261 lang=csharp
 *
 * [1261] Find Elements in a Contaminated Binary Tree
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
public class FindElements {

    TreeNode root;

    public FindElements(TreeNode root) {
        this.root = root;
    }
    
    public bool Find(int target) {
        TreeNode node = root;
        target++;
        int depth = int.Log2(target);
        int min = 1 << depth,
            max = (1 << (depth + 1)) - 1,
            mid = 0;

        while (depth > 0 && node != null)
        {
            mid = min + ((max - min) >> 1);
            if (mid >= target)
            {
                if (node.left == null)
                {
                    return false;
                }

                node = node.left;
                max = mid;
            }
            else
            {
                if (node.right == null)
                {
                    return false;
                }

                node = node.right;
                min = mid + 1;
            }

            depth--;
        }

        return true;
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */
// @lc code=end

