/*
 * @lc app=leetcode id=1561 lang=csharp
 *
 * [1561] Maximum Number of Coins You Can Get
 */

// @lc code=start
public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);

        int n = piles.Length / 3,
            count = 0,
            result = 0;
        
        for (int i = piles.Length - 2; count < n; i -= 2)
        {
            result += piles[i];
            count++;
        }

        return result;
    }
}
// @lc code=end

