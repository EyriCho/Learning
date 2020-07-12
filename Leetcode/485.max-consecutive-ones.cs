/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                count = 0;
            else
                count++;
            max = count > max ? count : max;
        }
        return max;
    }
}
// @lc code=end

