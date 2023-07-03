/*
 * @lc app=leetcode id=1575 lang=csharp
 *
 * [1575] Count All Possible Routes
 */

// @lc code=start
public class Solution {
    public int CountRoutes(int[] locations, int start, int finish, int fuel) {
        var consumes = new int[locations.Length, locations.Length];
        for (int i = 0; i < locations.Length; i++)
        {
            for (int j = i + 1; j < locations.Length; j++)
            {
                consumes[i, j] = Math.Abs(locations[i] - locations[j]);
            }
        }


        var dp = new int[fuel + 1, locations.Length];

        for (int f = 0; f <= fuel; f++)
        {
            dp[f, finish] = 1;
        }

        for (int f = 1; f <= fuel; f++)
        {
            for (int i = 0; i < locations.Length; i++)
            {
                for (int j = i + 1; j < locations.Length; j++)
                {
                    if (f >= consumes[i, j])
                    {
                        dp[f, i] = (dp[f, i] + dp[f - consumes[i, j], j]) % 1_000_000_007;
                        dp[f, j] = (dp[f, j] + dp[f - consumes[i, j], i]) % 1_000_000_007;
                    }
                }
            }
        }

        return dp[fuel, start];
    }
}
// @lc code=end

