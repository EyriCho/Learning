/*
 * @lc app=leetcode id=1979 lang=csharp
 *
 * [1979] Find Greatest Common Divisor of Array
 */

// @lc code=start
public class Solution {
    public int FindGCD(int[] nums) {
        int min = 1_000,
            max = 0,
            temp = 0;
        foreach (int num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        while (min > 0)
        {
            temp = max;
            max = min;
            min = temp % min;
        }

        return max;
    }
}
// @lc code=end

