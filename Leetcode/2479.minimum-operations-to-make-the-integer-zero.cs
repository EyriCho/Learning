/*
 * @lc app=leetcode id=2479 lang=csharp
 *
 * [2479] Minimum Operations to Make the Integer Zero
 */

// @lc code=start
public class Solution {
    public int MakeTheIntegerZero(int num1, int num2) {
        long x = 0L;
        for (int k = 1; k <= 60; k++)
        {
            x = num1 - 1L * num2 * k;
            if (x < k)
            {
                return -1;
            }

            if (k >= Int64.PopCount(x))
            {
                return k;
            }
        }

        return -1;
    }
}
// @lc code=end

