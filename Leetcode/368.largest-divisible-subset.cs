/*
 * @lc app=leetcode id=368 lang=csharp
 *
 * [368] Largest Divisible Subset
 */

// @lc code=start
public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        
        int maxLen = 1, maxIndex = 0;
        int[] dp = new int[nums.Length],
            path = new int[nums.Length];
        Array.Fill(dp, 1);
        Array.Fill(path, -1);
        
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                    path[i] = j;
                }
            }
            
            if (dp[i] > maxLen)
            {
                maxLen = dp[i];
                maxIndex = i;
            }
        }
        
        var result = new List<int>(maxLen);
        while (maxIndex > -1)
        {
            result.Add(nums[maxIndex]);
            maxIndex = path[maxIndex];
        }
        return result;
    }
}
// @lc code=end

