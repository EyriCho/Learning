/*
 * @lc app=leetcode id=3312 lang=csharp
 *
 * [3312] Sorted GCD Pair Queries
 */

// @lc code=start
public class Solution {
    public int[] GcdValues(int[] nums, long[] queries) {
        int max = nums.Max();
        long[] counts = new long[max + 1];
        foreach (int num in nums)
        {
            counts[num]++;
        }

        for (int i = 1; i <= max; i++)
        {
            for (int j = i << 1; j <= max; j += i)
            {
                counts[i] += counts[j];
            }
        }

        for (int i = 1; i <= max; i++)
        {
            counts[i] = counts[i] * (counts[i] - 1) / 2;
        }

        for (int i = max; i >= 1; i--)
        {
            for (int j = i << 1; j <= max; j += i)
            {
                counts[i] -= counts[j];
            }
        }

        for (int i = 1; i <= max; i++)
        {
            counts[i] += counts[i - 1];
        }

        long query = 0;
        int l = 0, r = 0, m = 0;
        int[] result = new int[queries.Length];
        for (int q = 0; q < queries.Length; q++)
        {
            query = queries[q] + 1L;
            l = 1;
            r = max;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (counts[m] >= query)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            result[q] = l;
        }

        return result;        
    }
}
// @lc code=end

