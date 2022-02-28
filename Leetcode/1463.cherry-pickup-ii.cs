/*
 * @lc app=leetcode id=1463 lang=csharp
 *
 * [1463] Cherry Pickup II
 */

// @lc code=start
public class Solution {
    public int CherryPickup(int[][] grid) {
        var dp = new int[grid.Length,grid[0].Length,grid[0].Length];
        
        int dfs(int row, int robot1, int robot2)
        {
            if (row == grid.Length)
                return 0;
            
            if (dp[row, robot1, robot2] > 0)
                return dp[row, robot1, robot2];
            
            int val = 0;
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    int nextRobot1 = robot1 + i,
                        nextRobot2 = robot2 + j;
                    
                    if (nextRobot1 >= 0 && nextRobot1 < grid[0].Length &&
                        nextRobot2 >= 0 && nextRobot2 < grid[0].Length)
                        val = Math.Max(val, dfs(row + 1, nextRobot1, nextRobot2));
                }
            
            val += grid[row][robot1];
            if (robot1 != robot2)
                val += grid[row][robot2];
            
            dp[row, robot1, robot2] = val;
            return val;
        }
        
        return dfs(0, 0, grid[0].Length - 1);
    }
}
// @lc code=end

