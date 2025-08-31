/*
 * @lc app=leetcode id=3363 lang=csharp
 *
 * [3363] Find the Maximum Number of Fruits Collected
 */

// @lc code=start
public class Solution {
    public int MaxCollectedFruits(int[][] fruits) {
        int result = 0,
            last = fruits.Length - 1;
        int[,] dp = new int[fruits.Length, fruits.Length];
        for (int i = 0; i < fruits.Length; i++)
        {
            result += fruits[i][i];
            fruits[i][i] = 0;
        }

        int bMax = 0, cMax = 0,
            prev = 0;
        for (int row = last - 1; row >= 0; row--)
        {
            for (int col = row + 1; col < fruits.Length; col++)
            {
                bMax = 0;
                cMax = 0;
                for (int i = -1; i < 2; i++)
                {
                    prev = col + i;
                    if ((prev <= row + 1) || prev >= fruits.Length)
                    {
                        continue;
                    }

                    bMax = Math.Max(bMax, dp[prev, row + 1]);
                    cMax = Math.Max(cMax, dp[row + 1, prev]);
                }

                dp[col, row] = bMax + fruits[col][row];
                dp[row, col] = cMax + fruits[row][col];
            }
        }
        
        return result + dp[0, last] + dp[last, 0];
    }
}
// @lc code=end

