/*
 * @lc app=leetcode id=2218 lang=csharp
 *
 * [2218] Maximum Value of K Coins From Piles
 */

// @lc code=start
public class Solution {
    public int MaxValueOfCoins(IList<IList<int>> piles, int k) {
        foreach (var pile in piles)
        {
            for (int i = 1; i < pile.Count; i++)
            {
                pile[i] += pile[i - 1];
            }
        }

        var dp = new int[k + 1];
        var totalCoins = 0;

        foreach (var pile in piles)
        {
            totalCoins += pile.Count;
            var totalMin = Math.Min(totalCoins, k);
            for (int t = totalMin; t > 0; t--)
            {
                var coins = Math.Min(t, pile.Count);

                for (int i = 0; i < coins; i++)
                {
                    dp[t] = Math.Max(dp[t], dp[t - i - 1] + pile[i]);
                }
            }
        }

        return dp[k];
    }
}
// @lc code=end

