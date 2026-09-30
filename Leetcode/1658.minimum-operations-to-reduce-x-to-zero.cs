/*
 * @lc app=leetcode id=1658 lang=csharp
 *
 * [1658] Minimum Operations to Reduce X to Zero
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int x) {
        int l = 0, r = nums.Length - 1,
            sum = 0,
            result = nums.Length;

        while (l < nums.Length && sum < x)
        {
            sum += nums[l++];
        }

        if (l == nums.Length)
        {
            return sum == x ? nums.Length : -1;
        }

        if (sum == x)
        {
            result = Math.Min(result, l);
        }

        for (l--; l >= 0; l--)
        {
            sum -= nums[l];

            while (r > l && sum < x)
            {
                sum += nums[r--];
            }

            if (sum == x)
            {
                result = Math.Min(result, l + nums.Length - 1 - r);
            }
        }

        return result == nums.Length ? -1 : result;
    }
}
// @lc code=end

