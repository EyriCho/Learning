/*
 * @lc app=leetcode id=976 lang=csharp
 *
 * [976] Largest Perimeter Triangle
 */

// @lc code=start
public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        
        for (int i = nums.Length - 1; i > 1; i--)
        {
            if (nums[i - 1] + nums[i - 2] > nums[i])
            {
                return nums[i - 1] + nums[i - 2] + nums[i];
            }
        }
        
        return 0;
    }
}
// @lc code=end

