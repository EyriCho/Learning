/*
 * @lc app=leetcode id=236 lang=csharp
 *
 * [236] Lowest Common Ancestor of a Binary Tree
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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return root;
        
        var pList = new List<TreeNode>();
        var qList = new List<TreeNode>();
        bool pIsFind = false, qIsFind = false;
        var node = root;
        while (node != null)
        {
            if (pIsFind && qIsFind) break;
            
            if (node.left == null)
            {
                if (pIsFind == false) pList.Add(node);
                if (qIsFind == false) qList.Add(node);
                if (p.val == node.val) pIsFind = true;
                if (q.val == node.val) qIsFind = true;
                node = node.right;
            }
            else
            {
                var prev = node.left;
                while (prev.right != null && prev.right != node)
                {
                    prev = prev.right;
                }
                if (prev.right == null)
                {
                    prev.right = node;
                    if (pIsFind == false) pList.Add(node);
                    if (qIsFind == false) qList.Add(node);
                    if (p.val == node.val) pIsFind = true;
                    if (q.val == node.val) qIsFind = true;
                    node = node.left;
                }
                else
                {
                    prev.right = null;
                    if (pIsFind == false) 
                    {
                        var pIndex = pList.IndexOf(node);
                        pList.RemoveRange(pIndex + 1, pList.Count - pIndex - 1);
                    };
                    if (qIsFind == false) qList.Add(node);
                    {
                        var qIndex = qList.IndexOf(node);
                        qList.RemoveRange(qIndex + 1, qList.Count - qIndex - 1);
                    };
                   node = node.right;
                }
            }
        }

        var i = 0;
        for (; i < pList.Count; i++)
        {
            if (pList[i].val != qList[i].val)
                break;
        }
        return pList[i - 1];
    }
}
// @lc code=end

