/*
 * @lc app=leetcode id=1512 lang=csharp
 *
 * [1512] Number of Good Pairs
 */

// @lc code=start
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

