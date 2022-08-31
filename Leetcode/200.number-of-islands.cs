/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 },
        };
        
        int count = 0;
        
        void IdentifyIsland(int x, int y)
        {
            grid[x][y] = '0';
            
            for (int i = 0; i < 4; i++)
            {
                int r = x + directions[i, 0],
                    c = y + directions[i, 1];
                
                if (r < 0 || r >= grid.Length ||
                    c < 0 || c >= grid[0].Length)
                {
                    continue;
                }
                if (grid[r][c] != '1')
                {
                    continue;
                }
                
                IdentifyIsland(r, c);
            }
        }
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    IdentifyIsland(i, j);
                    count++;
                }
            }
        }
        
        
        return count;
    }
}
// @lc code=end

