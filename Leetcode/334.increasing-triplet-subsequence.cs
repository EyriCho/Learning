/*
 * @lc app=leetcode id=334 lang=csharp
 *
 * [334] Increasing Triplet Subsequence
 */

// @lc code=start
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if (nums.Length < 3)
            return false;
        
        int min = int.MaxValue,
            mid = int.MaxValue;
        
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] <= min)
                min = nums[i];
            else if (nums[i] <= mid)
                mid = nums[i];
            else
                return true;
        
        
        return false;
    }
}
// @lc code=end

