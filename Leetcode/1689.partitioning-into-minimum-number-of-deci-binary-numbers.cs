/*
 * @lc app=leetcode id=1689 lang=csharp
 *
 * [1689] Partitioning Into Minimum Number Of Deci-Binary Numbers
 */

// @lc code=start
public class Solution {
    public int MinPartitions(string n) {
        int result = 0;
        
        foreach (var c in n)
        {
            result = Math.Max(result, c - '0');
        }
        
        return result;
    }
}
// @lc code=end

