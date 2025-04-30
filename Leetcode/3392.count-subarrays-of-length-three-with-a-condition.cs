/*
 * @lc app=leetcode id=3392 lang=csharp
 *
 * [3392] Count Subarrays of Length Three With a Condition
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int count13 = 0,
            second = nums[0],
            result = 0;

        for (int i = 2; i < nums.Length; i++)
        {
            count13 = second + nums[i];
            second = nums[i - 1];
            if (count13 * 2 == second)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

