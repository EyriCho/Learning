/*
 * @lc app=leetcode id=2389 lang=csharp
 *
 * [2389] Longest Subsequence With Limited Sum
 */

// @lc code=start
public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        var result = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] <= queries[i])
                {
                    result[i] = j + 1;
                    break;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

