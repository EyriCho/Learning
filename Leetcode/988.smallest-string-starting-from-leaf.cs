/*
 * @lc app=leetcode id=988 lang=csharp
 *
 * [988] Smallest String Starting From Leaf
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
    public string SmallestFromLeaf(TreeNode root) {
        LinkedList<char> list = new ();
        string result = "~";

        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            list.AddFirst((char)(node.val + 'a'));
            if (node.left == null && node.right == null)
            {
                int i = 0;
                foreach (char c in list)
                {
                    if (i == result.Length)
                    {
                        break;
                    }

                    if (c > result[i])
                    {
                        i = result.Length;
                        break;
                    }
                    else if (c == result[i])
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i < result.Length)
                {
                    char[] array = new char[list.Count];
                    i = 0;
                    foreach (char c in list)
                    {
                        array[i++] = c;
                    }

                    result = new string(array);
                }
            }

            Dfs(node.left);
            Dfs(node.right);

            list.RemoveFirst();
        }

        Dfs(root);
        return result;
    }
}
// @lc code=end

