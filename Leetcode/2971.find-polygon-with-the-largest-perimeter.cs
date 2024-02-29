/*
 * @lc app=leetcode id=2971 lang=csharp
 *
 * [2971] Find Polygon With the Largest Perimeter
 */

// @lc code=start
public class Solution {
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);

        long prevSum = nums[0] + nums[1],
            result = -1;
        for (int i = 2; i < nums.Length; i++)
        {
            if (prevSum > nums[i])
            {
                result = prevSum + nums[i];
            }

            prevSum += nums[i];
        }

        return result;
    }
}
// @lc code=end

