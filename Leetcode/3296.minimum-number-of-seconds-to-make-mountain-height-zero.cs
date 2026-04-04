/*
 * @lc app=leetcode id=3296 lang=csharp
 *
 * [3296] Minimum Number of Seconds to Make Mountain Height Zero
 */

// @lc code=start
public class Solution {
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes) {
        int maxWorker = 0;
        foreach (int t in workerTimes)
        {
            maxWorker = Math.Max(maxWorker, t);
        }

        double total = 0D;

        long min = 1L,
            max = (mountainHeight + 1L) * mountainHeight * maxWorker / 2L,
            mid = 0L,
            result = 0L;

        while (min <= max)
        {
            mid = min + (max - min) / 2;

            total = 0D;

            foreach (int t in workerTimes)
            {
                total += Math.Floor((Math.Sqrt(8D * mid / t + 1D) - 1D) / 2D);
            }

            if (total >= mountainHeight)
            {
                result = mid;
                max = mid - 1L;
            }
            else
            {
                min = mid + 1L;
            }
        }

        return result;
    }
}
// @lc code=end

