/*
 * @lc app=leetcode id=2471 lang=csharp
 *
 * [2471] Minimum Number of Operations to Sort a Binary Tree by Level
 */

// @lc code=start
public class Solution {
    public int MinimumOperations(TreeNode root) {
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);

        int count = 0,
            i = 0,
            current = 0,
            next = 0,
            move = 0,
            result = 0;
        int[] array = null,
            ids = null;
        TreeNode node = null;
        while (queue.Count > 0)
        {
            count = queue.Count;
            array = new int[count];
            ids = new int[count];
            i = 0;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                ids[i] = i;
                array[i++] = node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            Array.Sort(array, ids);
            for (i = 0; i < ids.Length; i++)
            {
                if (ids[i] == -1)
                {
                    continue;
                }

                move = 0;
                next = ids[i];
                while (ids[next] >= 0)
                {
                    move++;
                    current = next;
                    next = ids[current];
                    ids[current] = -1;
                }

                result += move - 1;
            }
        }

        return result;
    }
}
// @lc code=end

