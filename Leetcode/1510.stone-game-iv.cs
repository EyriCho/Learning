/*
 * @lc app=leetcode id=1510 lang=csharp
 *
 * [1510] Stone Game IV
 */

// @lc code=start
public class Solution {
    public bool WinnerSquareGame(int n) {
        var dp = new bool[n + 1];
        dp[1] = true;
        var squares = new List<int>();
        for (int i = 1; i * i <= n; i++)
            squares.Add(i * i);
        
        for (int left = 3; left <= n; left++)
        {
            foreach (var square in squares)
            {
                if (square > left)
                    break;
                
                if (!dp[left - square])
                {
                    dp[left] = true;
                    break;
                }
            }
        }
        
        return dp[n];
    }
}
// @lc code=end

