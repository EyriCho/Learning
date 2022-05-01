/*
 * @lc app=leetcode id=1631 lang=csharp
 *
 * [1631] Path With Minimum Effort
 */

// @lc code=start
public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        var directions = new int[,] {
            { 0, -1 },
            { -1, 0 },
            { 0, 1 },
            { 1, 0 }
        };
        
        bool[,] visited;
        
        bool CanFind(int x, int y, int maxEffort)
        {
            if (x == 0 && y == 0)
            {
                return true;
            }
            
            visited[x, y] = true;
            for (int i = 0; i < 4; i++)
            {
                int r = x + directions[i, 0],
                    c = y + directions[i, 1];
                
                if (r >= 0 && r < heights.Length &&
                    c >= 0 && c < heights[0].Length &&
                    !visited[r, c])
                {
                    if (Math.Abs(heights[x][y] - heights[r][c]) <= maxEffort &&
                        CanFind(r, c, maxEffort))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        
        int l = 0, r = 1_000_000;
        int result = 1_000_000;
        
        while (l <= r)
        {
            int m = (l + r) >> 1;
            visited = new bool[heights.Length, heights[0].Length];
            if (CanFind(heights.Length - 1, heights[0].Length - 1, m))
            {
                result = Math.Min(m, result);
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }
        
        return result;
    }
}
// @lc code=end

