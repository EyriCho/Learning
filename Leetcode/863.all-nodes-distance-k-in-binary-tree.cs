/*
 * @lc app=leetcode id=863 lang=csharp
 *
 * [863] All Nodes Distance K in Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        var stack = new Stack<TreeNode>();
        
        bool FindTarget(TreeNode node)
        {
            stack.Push(node);
            if (node == target)
            {
                return true;
            }

            if (node.left != null &&
                FindTarget(node.left))
            {
                return true;
            }
            if (node.right != null &&
                FindTarget(node.right))
            {
                return true;
            }
            stack.Pop();
            return false;
        }
        FindTarget(root);

        var result = new List<int>();
        void FindResult(TreeNode node, int dist)
        {
            if (dist == k)
            {
                result.Add(node.val);
                return;
            }

            if (node.left != null)
            {
                FindResult(node.left, dist + 1);
            }

            if (node.right != null)
            {
                FindResult(node.right, dist + 1);
            }
        }

        TreeNode prev = null;
        var d = 0;
        while (stack.Count > 0 && d <= k)
        {
            var node = stack.Pop();
            if (d == k)
            {
                result.Add(node.val);
                break;
            }
            else
            {
                if (node.left != null &&
                    node.left != prev)
                {
                    FindResult(node.left, d + 1);
                }
                
                if (node.right != null &&
                    node.right != prev)
                {
                    FindResult(node.right, d + 1);
                }
            }
            prev = node;
            d++;
        }

        return result;
    }
}
// @lc code=end

