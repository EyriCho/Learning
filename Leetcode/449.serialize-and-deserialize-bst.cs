/*
 * @lc app=leetcode id=449 lang=csharp
 *
 * [449] Serialize and Deserialize BST
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
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null)
            return null;
        
        var results = new List<int>();
        
        var node = root;
        while (node != null)
        {
            if (node.left == null)
            {
                results.Add(node.val);
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null && prev.right != node)
                    prev = prev.right;
                if (prev.right == null)
                {
                    results.Add(node.val);
                    prev.right = node;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    node = node.right;
                }
            }
        }
        
        return string.Join(',', results);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (data == null)
            return null;
        
        var list = new List<int>();
        
        int temp = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == ',')
            {
                list.Add(temp);
                temp = 0;
            }
            else
            {
                temp = temp * 10 + (int)(data[i] - '0');
            }
        }
        list.Add(temp);
        
        return Build(list, 0, list.Count - 1);
    }
    private TreeNode Build(List<int> list, int start, int end)
    {
        if (start > end)
            return null;
        
        var result = new TreeNode(list[start]);
        int i = start + 1;
        while (i <= end)
        {
            if (list[start] < list[i])
                break;
            i++;
        }
        result.left = Build(list, start + 1, i - 1);
        result.right = Build(list, i, end);
            
        return result;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;
// @lc code=end

