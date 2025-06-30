/*
 * @lc app=leetcode id=2929 lang=csharp
 *
 * [2929] Distribute Candies Among Children II
 */

// @lc code=start
public class Solution {
    public long DistributeCandies(int n, int limit) {
        int min = Math.Max(0, n - 2 * limit),
            max = Math.Min(n, limit);
        long result = 0L;

        for (int i = min; i <= max; i++)
        {
            result += Math.Min(limit, n - i) - Math.Max(min, n - i - limit) + 1;
        }

        return result;
    }
}
// @lc code=end

