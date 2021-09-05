/*
 * @lc app=leetcode id=827 lang=csharp
 *
 * [827] Making A Large Island
 */

// @lc code=start
public class Solution {
    public int LargestIsland(int[][] grid) {
        var visited = new bool[grid.Length, grid.Length];
        var islands = new List<int>();
        islands.Add(0);
        var directions = new int[,] {
            { 0, -1 },
            { -1, 0 },
            { 0, 1 },
            { 1, 0 }
        };
        
        void TravelIsland(int x, int y, int num)
        {
            islands[num]++;
            visited[x, y] = true;
            grid[x][y] = num;
            
            for (int i = 0; i < 4; i++)
            {
                int nx = x + directions[i, 0],
                    ny = y + directions[i, 1];
                
                if (nx > -1 && nx < grid.Length &&
                   ny > -1 && ny < grid.Length &&
                   grid[nx][ny] == 1 && !visited[nx, ny])
                    TravelIsland(nx, ny, num);
            }
        }
        
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
                if (grid[i][j] == 1 && !visited[i, j])
                {
                    var n = islands.Count;
                    islands.Add(0);
                    TravelIsland(i, j, n);
                    result = Math.Max(islands[n], result);
                }
        
        var set = new HashSet<int>();
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
                if (grid[i][j] == 0)
                {
                    int c = 1;
                    set.Clear();
                    for (int k = 0; k < 4; k++)
                    {
                        int nx = i + directions[k, 0],
                            ny = j + directions[k, 1];
                        if (nx > -1 && nx < grid.Length &&
                           ny > -1 && ny < grid.Length &&
                           grid[nx][ny] > 0 &&
                           !set.Contains(grid[nx][ny]))
                        {
                            c += islands[grid[nx][ny]];
                            set.Add(grid[nx][ny]);
                        }
                    }
                    
                    result = Math.Max(result, c);
                }
        
        return result;
    }
}
// @lc code=end

