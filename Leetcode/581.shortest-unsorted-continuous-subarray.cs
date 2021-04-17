/*
 * @lc app=leetcode id=581 lang=csharp
 *
 * [581] Shortest Unsorted Continuous Subarray
 */

// @lc code=start
public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int minIndex = -1;
        int maxIndex = -2;
        int min = nums[nums.Length - 1];
        int max = nums[0];
        
        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[nums.Length - 1 - i]);
            
            if (nums[i] < max)
                maxIndex = i;
            
            if (nums[nums.Length - 1 - i] > min)
                minIndex = nums.Length - 1 - i;
        }
        
        return maxIndex - minIndex + 1;
    }
}
// @lc code=end

