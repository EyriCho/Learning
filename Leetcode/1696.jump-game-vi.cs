/*
 * @lc app=leetcode id=1696 lang=csharp
 *
 * [1696] Jump Game VI
 */

// @lc code=start
public class Solution {
    public int MaxResult(int[] nums, int k) {
        int[] dp = new int[nums.Length],
            queue = new int[nums.Length];
        int front = 0, end = 0;
        
        dp[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (front <= end && queue[front] < i - k)
                front++;
            dp[i] = nums[i] + dp[queue[front]];
            
            while (front <= end && dp[queue[end]] <= dp[i])
                end--;
            queue[++end] = i;
        }
        
        return dp[nums.Length - 1];
    }
}
// @lc code=end

