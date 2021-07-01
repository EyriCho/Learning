/*
 * @lc app=leetcode id=1004 lang=csharp
 *
 * [1004] Max Consecutive Ones III
 */

// @lc code=start
public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0, right = 0;
        for (;right < nums.Length; right++)
        {
            if (nums[right] == 0)
                k--;
            
            if (k < 0 && nums[left++] == 0)
                k++;
        }
        
        return right - left;
    }
}
// @lc code=end

