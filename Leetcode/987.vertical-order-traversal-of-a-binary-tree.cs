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
        
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));
        
        while (queue.Count > 0)
        {
            for (int j = queue.Count; j > 0; j--)
            {
                var (node, index) = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue((node.left, index - 1));
                }
                
                if (node.right != null)
                {
                    queue.Enqueue((node.right, index + 1));
                }
                
                if (!dict.TryGetValue(index, out List<int> list))
                {
                    dict[index] = list = new List<int>();
                }
                list.Add(node.val);
            }
            
            foreach (var kv in dict)
            {
                var ni = i + kv.Key;
                if (ni < 0)
                {
                    result.Insert(0, new List<int>());
                    ni = 0;
                    i++;
                }
                else if(ni >= result.Count)
                {
                    result.Add(new List<int>());
                }
                
                kv.Value.Sort();
                foreach (var num in kv.Value)
                {
                    result[ni].Add(num);
                }
            }
            
            dict.Clear();
        }
        return result;
    }
}
// @lc code=end

