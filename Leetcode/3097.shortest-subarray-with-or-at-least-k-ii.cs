/*
 * @lc app=leetcode id=3097 lang=csharp
 *
 * [3097] Shortest Subarray With OR at Least K II
 */

// @lc code=start
public class Solution {
    public int MinimumSubarrayLength(int[] nums, int k) {
        int min = int.MaxValue,
            number = 0,
            l = 0,
            r = 0,
            masking = 1;
        int[] bitCounts = new int[32];

        while (r < nums.Length)
        {
            masking = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((nums[r] & masking) > 0)
                {
                    bitCounts[i]++;
                    if (bitCounts[i] == 1)
                    {
                        number += masking;
                    }
                }
                masking <<= 1;
            }
            while (l <= r && number >= k)
            {
                min = Math.Min(min, r - l + 1);

                masking = 1;
                for (int i = 0; i < 32; i++)
                {
                    if ((nums[l] & masking) > 0)
                    {
                        bitCounts[i]--;
                        if (bitCounts[i] == 0)
                        {
                            number -= masking;
                        }
                    }
                    masking <<= 1;
                }
                l++;
            }

            r++;
        }

        return min == int.MaxValue ? -1 : min;
    }
}
// @lc code=end

