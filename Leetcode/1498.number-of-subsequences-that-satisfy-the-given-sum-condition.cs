/*
 * @lc app=leetcode id=1498 lang=csharp
 *
 * [1498] Number of Subsequences That Satisfy the Given Sum Condition
 */

// @lc code=start
public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        var power2 = new int[nums.Length];
        power2[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            power2[i] = (power2[i - 1] << 1) % 1_000_000_007;
        }

        int l = 0,
            r = nums.Length - 1;

        int result = 0;
        while (l <= r)
        {
            if (nums[l] + nums[r] > target)
            {
                r--;
            }
            else
            {
                result = (result + power2[r - l]) % 1_000_000_007;
                l++;
            }
        }
        return result;
    }
}
// @lc code=end

