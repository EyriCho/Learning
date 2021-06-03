/*
 * @lc app=leetcode id=1689 lang=csharp
 *
 * [1689] Partitioning Into Minimum Number Of Deci-Binary Numbers
 */

// @lc code=start
public class Solution {
    public int MinPartitions(string n) {
        var c = '0';
        foreach (var digit in n)
        {
            if (digit == '9')
                return 9;
            else if (digit > c)
                c = digit;
        }
        return c - '0';
    }
}
// @lc code=end

