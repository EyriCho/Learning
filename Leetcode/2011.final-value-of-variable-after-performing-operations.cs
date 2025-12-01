/*
 * @lc app=leetcode id=2011 lang=csharp
 *
 * [2011] Final Value of Variable After Performing Operations
 */

// @lc code=start
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int add = 0;
        foreach (string op in operations)
        {
            if (op.Contains('+'))
            {
                add++;
            }
        }
        return (add << 1) - operations.Length;
    }
}
// @lc code=end

