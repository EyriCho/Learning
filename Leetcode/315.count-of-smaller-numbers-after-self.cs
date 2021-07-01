/*
 * @lc app=leetcode id=315 lang=csharp
 *
 * [315] Count of Smaller Numbers After Self
 */

// @lc code=start
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var result = new int[nums.Length];
        
        var root = new TreeNode(nums[nums.Length - 1]);
        for (int i = nums.Length - 2; i > -1; i--)
        {
            Count = 0;
            root = Insert(root, nums[i]);
            result[i] = Count;
        }
        
        return result;
    }
    
    private int Count;
    
    private TreeNode Insert(TreeNode node, int val)
    {
        if (node == null)
            return new TreeNode(val);
        
        if (val < node.val)
        {
            node.lessCount++;
            node.left = Insert(node.left, val);
        }
        else if (val > node.val)
        {
            Count += node.lessCount + node.eqCount;
            node.right = Insert(node.right, val);
        }
        else
        {
            node.eqCount++;
            Count += node.lessCount;
            return node;
        }
        
        node.UpdateHeight();
        var balance = node.GetBalance();
        
        if (balance > 1 && val < node.left?.val)
            return RotateRight(node);
        if (balance > 1 && val > node.left?.val)
        {
            node.left = RotateLeft(node.left);
            return RotateRight(node);
        }
        
        if (balance < -1 && val < node.right?.val)
        {
            node.right = RotateRight(node.right);
            return RotateLeft(node);
        }
        if (balance < -1 && val > node.right?.val)
            return RotateLeft(node);
        
        return node;
    }
    
    private TreeNode RotateRight(TreeNode node)
    {
        var n = node.left;
        var nr = n.right;
        
        n.right = node;
        node.left = nr;
        
        
        node.UpdateHeight();
        n.UpdateHeight();
        
        node.lessCount -= n == null ? 0 : (n.lessCount + n.eqCount);
        
        return n;
    }
    
    private TreeNode RotateLeft(TreeNode node)
    {
        var n = node.right;
        var nl = n.left;
        
        n.left = node;
        node.right = nl;
        
        node.UpdateHeight();
        n.UpdateHeight();
        
        n.lessCount += n == null ? 0 : (node.lessCount + node.eqCount);
        
        return n;
    }
    
}

internal class TreeNode
{
    internal int val;
    internal int lessCount;
    internal int eqCount;
    internal int height;
    internal TreeNode left;
    internal TreeNode right;

    internal TreeNode(int v)
    {
        val = v;
        lessCount = 0;
        eqCount = 1;
    }
}

internal static class Extensions
{
    internal static int GetHeight(this TreeNode node)
    {
        if (node == null)
            return 0;
        return node.height;
    }

    internal static void UpdateHeight(this TreeNode node)
    {
        if (node == null)
            return;
        node.height = Math.Max(node.left.GetHeight(), node.right.GetHeight()) + 1;
    }

    internal static int GetBalance(this TreeNode node)
    {
        return node.left.GetHeight() - node.right.GetHeight();
    }
}
// @lc code=end

