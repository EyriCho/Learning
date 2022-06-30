/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if (amount == 0)
        {
            return 0;
        }
        var dp = new int[amount + 1];
        
        for (int i = 1; i <= amount; i++)
        {
            dp[i] = int.MaxValue;
            
            foreach (var coin in coins)
            {
                if (coin > i)
                {
                    continue;
                }
                
                if (dp[i - coin] == int.MaxValue)
                {
                    continue;
                }
                
                dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            }
        }
        
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}
// @lc code=end

