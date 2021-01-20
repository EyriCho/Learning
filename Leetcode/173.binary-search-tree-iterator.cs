/*
 * @lc app=leetcode id=173 lang=csharp
 *
 * [173] Binary Search Tree Iterator
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
public class BSTIterator {

    public BSTIterator(TreeNode root) {
        stack = new Stack<TreeNode>();
        while (root != null)
        {
            stack.Push(root);
            root = root.left;
        }
    }
    
    public int Next() {
        var result = stack.Pop();
        var n = result.right;
        while (n != null)
        {
            stack.Push(n);
            n = n.left;
        }
        return result.val;
    }
    
    public bool HasNext() {
        return stack.Count > 0;
    }
    
    Stack<TreeNode> stack;
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
// @lc code=end

