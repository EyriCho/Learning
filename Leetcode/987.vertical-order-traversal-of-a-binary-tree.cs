/*
 * @lc app=leetcode id=987 lang=csharp
 *
 * [987] Vertical Order Traversal of a Binary Tree
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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        var dict = new Dictionary<int, List<int>>();
        
        int i = 0;
        var queue = new Queue<(TreeNode, int)?>();
        queue.Enqueue((root, 0));
        queue.Enqueue(null);
        while (queue.Count > 0)
        {
            var next = queue.Dequeue();
            while (next != null)
            {
                (TreeNode node, int margin) = next.Value;
                if (node.left != null)
                    queue.Enqueue((node.left, margin - 1));
                if (node.right != null)
                    queue.Enqueue((node.right, margin + 1));
                
                if (!dict.ContainsKey(margin))
                    dict[margin] = new List<int>();
                dict[margin].Add(node.val);
                
                next = queue.Dequeue();
            }
            if (queue.Count > 0)
                queue.Enqueue(null);
            
            foreach (var entry in dict)
            {
                var ni = i + entry.Key;
                if (ni < 0)
                {
                    result.Insert(0, new List<int>());
                    ni = 0;
                    i++;
                }
                else if (ni >= result.Count)
                    result.Add(new List<int>());
                
                entry.Value.Sort();
                for (int j = 0; j < entry.Value.Count; j++)
                    result[ni].Add(entry.Value[j]);
            }
            
            dict.Clear();
        }
        
        return result;
    }
}
// @lc code=end

