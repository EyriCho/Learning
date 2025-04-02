/*
 * @lc app=leetcode id=1079 lang=csharp
 *
 * [1079] Letter Tile Possibilities
 */

// @lc code=start
public class Solution {
    public int NumTilePossibilities(string tiles) {
        int[,] combines = new int[tiles.Length + 1, tiles.Length + 1];
        for (int t = 0; t <= tiles.Length; t++)
        {
            combines[t, 0] = combines[t, t] = 1;
            for (int c = 1; c < t; c++)
            {
                combines[t, c] = combines[t - 1, c] + combines[t - 1, c - 1];
            }
        }

        Dictionary<char, int> counts = new ();
        int count = 0;
        foreach (char c in tiles)
        {
            counts.TryGetValue(c, out count);
            counts[c] = count + 1;
        }

        int[,] dp = new int[counts.Count + 1, tiles.Length + 1];
        dp[0, 0] = 1;
        int i = 1;
        foreach (int c in counts.Values)
        {
            for (int j = 0; j <= tiles.Length; j++)
            {
                for (int k = 0; k <= j && k <= c; k++)
                {
                    dp[i, j] += dp[i - 1, j - k] * combines[j, k];
                }
            }

            i++;
        }

        int result = 0;
        for (i = 1; i <= tiles.Length; i++)
        {
            result += dp[counts.Count, i];
        }
        return result;
    }
}
// @lc code=end

