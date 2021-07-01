/*
 * @lc app=leetcode id=795 lang=csharp
 *
 * [795] Number of Subarrays with Bounded Maximum
 */

// @lc code=start
public class Solution {
    public int NumSubarrayBoundedMax(int[] nums, int left, int right) {
        int downCount = 0,
            validCount = 0,
            result = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > right)
            {
                downCount = validCount = 0;
                continue;
            }
            
            if (nums[i] < left)
                downCount++;
            else
                downCount = 0;
                
            validCount++;
            result += validCount - downCount;
        }
        
        return result;
    }
}
// @lc code=end

