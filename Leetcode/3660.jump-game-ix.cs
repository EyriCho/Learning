/*
 * @lc app=leetcode id=3660 lang=csharp
 *
 * [3660] Jump Game IX
 */

// @lc code=start
public class Solution {
    public int[] MaxValue(int[] nums) {
        int[] prefix = new int[nums.Length],
            suffix = new int[nums.Length],
            result = new int[nums.Length];

        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = Math.Max(prefix[i - 1], nums[i]);
        }

        result[^1] = prefix[^1];
        suffix[^1] = nums[^1];
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (prefix[i] > suffix[i + 1])
            {
                result[i] = result[i + 1];
            }
            else
            {
                result[i] = prefix[i];
            }

            suffix[i] = Math.Min(suffix[i + 1], nums[i]);
        }

        return result;
    }
}
// @lc code=end

