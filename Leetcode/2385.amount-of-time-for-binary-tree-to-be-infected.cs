/*
 * @lc app=leetcode id=2385 lang=csharp
 *
 * [2385] Amount of Time for Binary Tree to Be Infected
 */

// @lc code=start
public class Solution {
    public int AmountOfTime(TreeNode root, int start) {
        Dictionary<TreeNode, IList<TreeNode>> dict = new ();
        HashSet<TreeNode> set = new ();
        TreeNode startNode = null;

        void Travel(TreeNode prev, TreeNode node)
        {
            if (node.val == start)
            {
                startNode = node;
            }

            set.Add(node);
            dict[node] = new List<TreeNode>();
            if (prev != null)
            {
                dict[node].Add(prev);
            }

            if (node.left != null)
            {
                dict[node].Add(node.left);
                Travel(node, node.left);
            }

            if (node.right != null)
            {
                dict[node].Add(node.right);
                Travel(node, node.right);
            }
        }

        Travel(null, root);

        Queue<TreeNode> queue = new ();
        queue.Enqueue(startNode);
        int result = -1;
        while (queue.Count > 0)
        {
            int c = queue.Count;
            while (c-- > 0)
            {
                TreeNode n = queue.Dequeue();
                set.Remove(n);

                foreach (TreeNode next in dict[n])
                {
                    if (set.Contains(next))
                    {
                        queue.Enqueue(next);
                    }
                }
            }

            result++;
        }

        return result;
    }
}
// @lc code=end

