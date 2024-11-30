/*
 * @lc app=leetcode id=862 lang=csharp
 *
 * [862] Shortest Subarray with Sum at Least K
 */

// @lc code=start
public class Solution {
    public int ShortestSubarray(int[] nums, int k) {
        long sum = 0L,
            left = 0L;
        int min = int.MaxValue,
            l = 0,
            r = 0,
            m = 0;

        List<(long, int)> list = new () {
            (0L, -1),
        };

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (list.Count > 0 && list[^1].Item1 > sum)
            {
                list.RemoveAt(list.Count - 1);
            }
            
            list.Add((sum, i));

            left = sum - k;
            l = 0;
            r = list.Count;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (list[m].Item1 > left)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            if (l > 0)
            {
                min = Math.Min(min, i - list[l - 1].Item2);
            }
        }

        return min == int.MaxValue ? -1 : min;
    }
}
// @lc code=end

