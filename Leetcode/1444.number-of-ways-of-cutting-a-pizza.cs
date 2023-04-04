/*
 * @lc app=leetcode id=1444 lang=csharp
 *
 * [1444] Number of Ways of Cutting a Pizza
 */

// @lc code=start
public class Solution {
    public int Ways(string[] pizza, int k) {
        var counts = new int[pizza.Length + 1, pizza[0].Length + 1];
        var dp = new long[k, pizza.Length, pizza[0].Length];

        var lastRow = pizza.Length - 1;
        var lastCol = pizza[0].Length - 1;        
        for (int i = lastRow; i >= 0; i--)
        {
            for (int j = lastCol; j >= 0; j--)
            {
                counts[i, j] += counts[i + 1, j] + counts[i, j + 1] - counts[i + 1, j + 1];
                
                if (pizza[i][j] == 'A')
                {
                    counts[i, j]++;
                }

                dp[0, i, j] = counts[i, j] > 0 ? 1L : 0L;
            }
        }

        for (int cuts = 1; cuts < k; cuts++)
        {
            for (int i = 0; i < pizza.Length; i++)
            {
                for (int j = 0; j < pizza[0].Length; j++)
                {
                    for (int row = i + 1; row < pizza.Length; row++)
                    {
                        if (counts[row, j] > 0 && counts[i, j] - counts[row, j] > 0)
                        {
                            dp[cuts, i, j] = (dp[cuts, i, j] + dp[cuts - 1, row, j]) % 1_000_000_007;
                        }
                    }

                    for (int col = j + 1; col < pizza[0].Length; col++)
                    {
                        if (counts[i, col] > 0 && counts[i, j] - counts[i, col] > 0)
                        {
                            dp[cuts, i, j] = (dp[cuts, i, j] + dp[cuts - 1, i, col]) % 1_000_000_007;
                        }
                    }
                }
            }
        }    

        return (int)dp[k - 1, 0, 0];
    }
}
// @lc code=end

