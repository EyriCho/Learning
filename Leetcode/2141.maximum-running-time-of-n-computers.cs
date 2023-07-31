/*
 * @lc app=leetcode id=2141 lang=csharp
 *
 * [2141] Maximum Running Time of N Computers
 */

// @lc code=start
public class Solution {
    public long MaxRunTime(int n, int[] batteries) {
        bool Check(long time)
        {
            var sum = 0L;
            foreach (var b in batteries)
            {
                sum += Math.Min(b, time);
            }

            return sum >= time * n;
        }

        long l = batteries[0],
            r = 0,
            m = 0;

        foreach (var b in batteries)
        {
            l = Math.Min(l, b);
            r += b;
        }

        r /= n;

        while (l < r)
        {
            m = (l + r + 1) >> 1;
            if (Check(m))
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}
// @lc code=end

