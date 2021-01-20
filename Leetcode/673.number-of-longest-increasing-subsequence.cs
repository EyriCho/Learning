/*
 * @lc app=leetcode id=673 lang=csharp
 *
 * [673] Number of Longest Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        if (nums.Length < 2)
            return nums.Length;
        
        int[] counts = new int[nums.Length],
            lengths = new int[nums.Length];
        counts[0] = 1;
        lengths[0] = 1;
        int maxLength = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            lengths[i] = 1;
            counts[i] = 1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (nums[j] < nums[i])
                {
                    if (lengths[j] >= lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        counts[i] = counts[j];
                    }
                    else if (lengths[j] + 1 == lengths[i])
                    {
                        counts[i] += counts[j];
                    }
                }
            }
            if (lengths[i] > maxLength)
                maxLength = lengths[i];
        }
        
        int maxCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxLength == lengths[i])
                maxCount += counts[i];
        }
        
        return maxCount;
    }
}
// @lc code=end

