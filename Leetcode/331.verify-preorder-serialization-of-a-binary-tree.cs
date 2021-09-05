/*
 * @lc app=leetcode id=331 lang=csharp
 *
 * [331] Verify Preorder Serialization of a Binary Tree
 */

// @lc code=start
public class Solution {
    public bool IsValidSerialization(string preorder) {
        preorder += ",";
        
        int count = 1;
        
        for (int i = 0; i < preorder.Length; i++)
        {
            if (preorder[i] != ',')
                continue;
            
            count--;
            if (count < 0)
                return false;
            
            if (preorder[i - 1] != '#')
                count += 2;
        }
        
        return count == 0;
    }
}
// @lc code=end

