/*
 * @lc app=leetcode id=1690 lang=csharp
 *
 * [1690] Stone Game VII
 */

// @lc code=start
public class Solution {
    public int StoneGameVII(int[] stones) {
        var sums = new int[stones.Length + 1];
        for (int i = 1; i <= stones.Length; i++)
            sums[i] = sums[i - 1] + stones[i - 1];
        
        var dp = new int[stones.Length + 1, stones.Length + 1];
        for (int i = 2; i <= stones.Length; i++)
            dp[i - 1, i] = Math.Max(stones[i - 2], stones[i - 1]);
        
        for (int len = 2; len <= stones.Length; len++)
            for (int l = 1; l + len <= stones.Length; l++)
            {
                var r = l + len;
                dp[l, r] = Math.Max(dp[l, r],
                    Math.Max(sums[r] - sums[l] - dp[l + 1, r], sums[r - 1] - sums[l - 1] - dp[l, r - 1]));
            }
        
        return dp[1, stones.Length];
    }
}
// @lc code=end

