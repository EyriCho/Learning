/*
 * @lc app=leetcode id=2196 lang=csharp
 *
 * [2196] Create Binary Tree From Descriptions 
 */

// @lc code=start
public class Solution {
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int, TreeNode> dict = new ();
        Dictionary<int, bool> hasParent = new ();

        foreach (int[] description in descriptions)
        {
            if (!dict.TryGetValue(description[1], out TreeNode child))
            {
                dict[description[1]] = child = new TreeNode(description[1]);
            }

            if (!dict.TryGetValue(description[0], out TreeNode parent))
            {
                dict[description[0]] = parent = new TreeNode(description[0]);
            }

            if (description[2] > 0)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }
            hasParent[description[1]] = true;
        }

        foreach (KeyValuePair<int, TreeNode> kv in dict)
        {
            if (!hasParent.ContainsKey(kv.Key))
            {
                return kv.Value;
            }
        }
        
        return null;
    }
}
// @lc code=end

