/*
 * @lc app=leetcode id=1295 lang=csharp
 *
 * [1295] Find Numbers with Even Number of Digits
 */

// @lc code=start
public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        foreach (int num in nums)
        {
            if (num < 10)
            {
                continue;
            }
            else if (num > 99 && num < 1_000)
            {
                continue;
            }
            else if (num > 9_999 && num < 100_000)
            {
                continue;
            }

            result++;
        }
        return result;
    }
}
// @lc code=end

