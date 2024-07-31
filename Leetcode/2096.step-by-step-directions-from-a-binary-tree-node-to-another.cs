/*
 * @lc app=leetcode id=2096 lang=csharp
 *
 * [2096] Step-By-Step Directions From a Binary Tree Node to Another
 */

// @lc code=start
public class Solution {
    public string GetDirections(TreeNode root, int startValue, int destValue) {
        
        TreeNode CommonAncestor(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.val == startValue ||
                node.val == destValue)
            {
                return node;
            }
            
            TreeNode left = CommonAncestor(node.left),
                right = CommonAncestor(node.right);

            if (left != null && right != null)
            {
                return node;
            }

            return left ?? right;
        }
        TreeNode ancestor = CommonAncestor(root);

        Stack<char> stack = new ();
        bool FindDirections(TreeNode node, int val)
        {
            if (node == null)
            {
                return false;
            }

            if (node.val == val)
            {
                return true;
            }

            stack.Push('L');
            if (FindDirections(node.left, val))
            {
                return true;
            }
            stack.Pop();
            stack.Push('R');
            if (FindDirections(node.right, val))
            {
                return true;
            }
            stack.Pop();
            return false;
        }

        FindDirections(ancestor, startValue);
        string start = new string('U', stack.Count);

        stack.Clear();
        FindDirections(ancestor, destValue);
        char[] destArray = new char[stack.Count];
        int i = stack.Count;
        while (i > 0)
        {
            destArray[--i] = stack.Pop();
        }

        return string.Concat(start, new string(destArray));
    }
}
// @lc code=end

