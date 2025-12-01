/*
 * @lc app=leetcode id=2528 lang=csharp
 *
 * [2528] Maximize the Minimum Powered City
 */

// @lc code=start
public class Solution {
    public long MaxPower(int[] stations, int r, int k) {
        long[] powers = new long[stations.Length];
        long window = 0L;
        for (int i = 0; i <= r; i++)
        {
            window += stations[i];
        }
        int idx = 0;
        long max = 0L;
        for (int i = 0; i < stations.Length; i++)
        {
            powers[i] = window;
            max = Math.Max(max, window);
            idx = i - r;
            if (idx >= 0)
            {
                window -= stations[idx];
            }
            idx = i + r + 1;
            if (idx < stations.Length)
            {
                window += stations[idx];
            }
        }

        bool IsPossible(long target)
        {
            long[] diff = new long[stations.Length + 1];
            long diffAdd = 0L,
                total = 0L,
                need = 0L,
                added = 0L;
            int end = 0;
            for (int i = 0; i < stations.Length; i++)
            {
                diffAdd += diff[i];
                total = powers[i] + diffAdd;
                if (total < target)
                {
                    need = target - total;
                    added += need;
                    if (added > k)
                    {
                        return false;
                    }
                    diffAdd += need;
                    end = Math.Min(stations.Length, i + 2 * r + 1);
                    diff[end] -= need;
                }
            }

            return true;
        }

        long left = 0L, right = max + k, mid = 0L;
        while (left < right)
        {
            mid = (left + right + 1) >> 1;
            if (IsPossible(mid))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}
// @lc code=end

