/*
 * @lc app=leetcode id=3075 lang=csharp
 *
 * [3075] Maximize Happiness of Selected Children
 */

// @lc code=start
public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);

        long result = 0L;
        for (int i = 0; i < k; i++)
        {
            long happy = Math.Max(happiness[happiness.Length - 1 - i] - i, 0L);
            result += happy;
        }

        return result;
    }
}
// @lc code=end

