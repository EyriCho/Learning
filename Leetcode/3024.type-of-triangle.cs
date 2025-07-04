/*
 * @lc app=leetcode id=3024 lang=csharp
 *
 * [3024] Type of Triangle
 */

// @lc code=start
public class Solution {
    public string TriangleType(int[] nums) {
        if (nums[0] == nums[1] && nums[1] == nums[2])
        {
            return "equilateral";
        }
        else if (nums[0] + nums[1] <= nums[2] ||
            nums[0] + nums[2] <= nums[1] ||
            nums[1] + nums[2] <= nums[0])
        {
            return "none";
        }
        else if (nums[0] == nums[1] ||
            nums[1] == nums[2] ||
            nums[0] == nums[2])
        {
            return "isosceles";
        }
        else
        {
            return "scalene";
        }
    }
}
// @lc code=end

