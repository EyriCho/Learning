/*
 * @lc app=leetcode id=945 lang=csharp
 *
 * [945] Minimum Increment to Make Array Unique
 */

// @lc code=start
public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int min = nums[0],
            result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            min++;
            if (nums[i] < min)
            {
                result += min - nums[i];
            }
            else if (nums[i] > min)
            {
                min = nums[i];
            }
        }

        return result;
    }
}
// @lc code=end

