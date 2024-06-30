/*
 * @lc app=leetcode id=995 lang=csharp
 *
 * [995] Minimum Number of K Consecutive Bit Flips
 */

// @lc code=start
public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        int result = 0,
            flips = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] + flips) % 2 == 0)
            {
                if (i > nums.Length - k)
                {
                    return -1;
                }

                result++;
                flips++;
                nums[i] = -1;
            }

            if (i + 1 >= k)
            {
                flips -= nums[i - k + 1] < 0 ? 1 : 0;
            }
        }

        return result;
    }
}
// @lc code=end

