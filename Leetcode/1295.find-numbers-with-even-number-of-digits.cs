/*
 * @lc app=leetcode id=1295 lang=csharp
 *
 * [1295] Find Numbers with Even Number of Digits
 */

// @lc code=start
public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        foreach (int number in nums)
        {
            int num = number;
            int numCount = 0;
            while (num != 0)
            {
                num = num / 10;
                numCount++;
            }
            if (numCount % 2 == 0)
                count++;
        }
        return count;
    }
}
// @lc code=end

