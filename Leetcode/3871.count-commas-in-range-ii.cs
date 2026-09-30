/*
 * @lc app=leetcode id=3871 lang=csharp
 *
 * [3871] Count Commas in Range II
 */

// @lc code=start
public class Solution {
    public long CountCommas(long n) {
        long result = 0L,
            p = 1_000L;
        while (p <= n)
        {
            result += n - p + 1;
            p *= 1_000L;
        }
        
        return result;
    }
}
// @lc code=end

