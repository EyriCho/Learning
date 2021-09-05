/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int LengthOfLIS(int[] nums) {
        var array = new int[nums.Length];
        array[0] = nums[0];
        int length = 1;
        
        for (int i = 1; i < nums.Length; i++)
        {
            var index = Array.BinarySearch(array, 0, length, nums[i]);
            if (index < 0)
                index = ~index;
            if (index >= length)
                array[length++] = nums[i];
            else
                array[index] = nums[i];
        }
        
        return length;
    }
}
// @lc code=end

