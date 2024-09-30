/*
 * @lc app=leetcode id=2028 lang=csharp
 *
 * [2028] Find Missing Observations
 */

// @lc code=start
public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        int total = mean * (rolls.Length + n);
        foreach (int roll in rolls)
        {
            total -= roll;
        }
        if (total < n || total > n * 6)
        {
            return new int[0];
        }
        int[] result = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            if (total > i + 1)
            {
                result[i] = Math.Min(total - i, 6);
            }
            else
            {
                result[i] = 1;
            }
            total -= result[i];
        }

        return result;
    }
}
// @lc code=end

