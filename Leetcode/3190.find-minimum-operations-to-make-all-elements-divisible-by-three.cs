/*
 * @lc app=leetcode id=3190 lang=csharp
 *
 * [3190] Find Minimum Operations to Make All Elements Divisible by Three
 */

// @lc code=start
public class Solution {
    public int MinimumOperations(int[] nums) {
        int result = 0;
        foreach (int num in nums)
        {
            if (num % 3 == 0)
            {
                continue;
            }
            result++;
        }
        return result;
    }
}
// @lc code=end

