/*
 * @lc app=leetcode id=920 lang=csharp
 *
 * [920] Number of Music Playlists
 */

// @lc code=start
public class Solution {
    public int NumMusicPlaylists(int n, int goal, int k) {
        var dp = new long[goal + 1, n + 1];
        dp[0, 0] = 1;

        for (int g = 1; g <= goal; g++)
        {
            var maxSong = Math.Min(g, n);
            for (int t = 1; t <= maxSong; t++)
            {
                dp[g, t] = (long)dp[g - 1, t - 1] * (n - t + 1) % 1_000_000_007;
                if (t > k)
                {
                    dp[g, t] = ((long)dp[g, t] + dp[g - 1, t] * (t - k)) % 1_000_000_007;
                }
            }
        }

        return (int)dp[goal, n];
    }
}
// @lc code=end

