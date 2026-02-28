/*
 * @lc app=leetcode id=3010 lang=csharp
 *
 * [3010] Divide an Array Into Subarrays With Minimum Cost I
 */

// @lc code=start
public class Solution {
    public int MinimumCost(int[] nums) {
        int a = nums[0],
            b = int.MaxValue,
            c = int.MaxValue;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < b)
            {
                c = b;
                b = nums[i];
            }
            else if (nums[i] < c)
            {
                c = nums[i];
            }
        }

        return a + b + c;
    }
}
// @lc code=end

