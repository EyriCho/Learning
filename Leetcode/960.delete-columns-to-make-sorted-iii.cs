/*
 * @lc app=leetcode id=960 lang=csharp
 *
 * [960] Delete Columns to Make Sorted III
 */

// @lc code=start
public class Solution {
    public int MinDeletionSize(string[] strs) {
        int[] dp = new int[strs[0].Length];
        Array.Fill(dp, 1);

        bool ok = true;
        for (int r = 1; r < strs[0].Length; r++)
        {
            for (int l = 0; l < r; l++)
            {
                ok = true;
                for (int s = 0; s < strs.Length; s++)
                {
                    if (strs[s][l] > strs[s][r])
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    dp[r] = Math.Max(dp[r], dp[l] + 1);
                }
            }
        }

        int max = 0;
        for (int c = 0; c < strs[0].Length; c++)
        {
            max = Math.Max(max, dp[c]);
        }
        return strs[0].Length - max;
    }
}
// @lc code=end

