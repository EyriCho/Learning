/*
 * @lc app=leetcode id=174 lang=csharp
 *
 * [174] Dungeon Game
 */

// @lc code=start
public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        var dp = new int[dungeon.Length, dungeon[0].Length];
        
        int i = dungeon.Length - 1,
            j = dungeon[0].Length - 1;
        
        dp[i, j] = Math.Max(1 - dungeon[i][j], 1);
        
        i = dungeon.Length - 2;
        j = dungeon[0].Length - 1;
        
        for (; i >= 0; i--)
            dp[i, j] = Math.Max(dp[i + 1, j] - dungeon[i][j], 1);
        
        i = dungeon.Length - 1;
        j = dungeon[0].Length - 2;
        
        for (; j >= 0; j--)
            dp[i, j] = Math.Max(dp[i, j + 1] - dungeon[i][j], 1);
        
        for (i = dungeon.Length - 2; i >= 0; i--)
            for (j = dungeon[0].Length - 2; j >= 0; j--)
            {
                int down = Math.Max(dp[i + 1, j] - dungeon[i][j], 1);
                int right = Math.Max(dp[i, j + 1] - dungeon[i][j], 1);
                dp[i, j] = Math.Min(down, right);
            }
        
        return dp[0,0];
    }
}
// @lc code=end

