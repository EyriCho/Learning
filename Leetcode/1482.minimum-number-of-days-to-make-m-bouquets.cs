/*
 * @lc app=leetcode id=1482 lang=csharp
 *
 * [1482] Minimum Number of Days to Make m Bouquets
 */

// @lc code=start
public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        if (bloomDay.Length < (long)m * k)
        {
            return -1;
        }

        bool CanBouquets(int day)
        {
            int last = -1,
                bouquets = 0;
            for (int i = 0; i < bloomDay.Length; i++)
            {
                if (bloomDay[i] <= day)
                {
                    if (i - last >= k)
                    {
                        last = i;
                        bouquets++;
                    }
                }
                else
                {
                    last = i;
                }
            }

            return bouquets >= m;
        }

        int l = 1,
            r = bloomDay.Max(),
            mid = 0;

        while (l < r)
        {
            mid = l + ((r - l) >> 1);
            if (CanBouquets(mid))
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }

        return l;
    }
}
// @lc code=end

