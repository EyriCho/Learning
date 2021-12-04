/*
 * @lc app=leetcode id=980 lang=csharp
 *
 * [980] Unique Paths III
 */

// @lc code=start
public class Solution {
    public int UniquePathsIII(int[][] grid) {
        int startX = 0, startY = 0;
        int count = 0, result = 0;
            
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    startX = i;
                    startY = j;
                }
                else if (grid[i][j] == 0)
                    count++;
                else if (grid[i][j] == 2)
                    count++;
            }
        
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 },
        };
        var visited = new bool[grid.Length, grid[0].Length];
        
        void FindPath(int x, int y)
        {
            if (x < 0 || x >= grid.Length ||
                y < 0 || y >= grid[0].Length ||
                visited[x, y] || grid[x][y] < 0)
                return;
            
            if (grid[x][y] == 2)
            {
                result += (count == 0 ? 1 : 0);
                return;
            }
            
            visited[x, y] = true;
            count--;
            
            for (int i = 0; i < 4; i++)
                FindPath(x + directions[i, 0], y + directions[i, 1]);
            
            visited[x, y] = false;
            count++;
        }
        
        FindPath(startX, startY);
        return result;
    }
}
// @lc code=end

