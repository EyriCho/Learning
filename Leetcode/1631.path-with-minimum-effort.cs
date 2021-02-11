/*
 * @lc app=leetcode id=1631 lang=csharp
 *
 * [1631] Path With Minimum Effort
 */

// @lc code=start
public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        int l = 0, r = 1_000_000;
        int result = 1_000_000;
        while (l <= r)
        {
            int m = (l + r) / 2;
            var visited = new bool[heights.Length, heights[0].Length];
            if (CanFindPath(heights, visited, m, 0, 0))
            {
                result = Math.Min(m, result);
                r = m - 1;
            }
            else
                l = m + 1;
        }
        
        return result;
    }
    
    int[] dx = {-1, 0, 1, 0};
    int[] dy = {0, 1, 0, -1};
    
    private bool CanFindPath(int[][] heights, bool[,] visited, int threshold,
        int x, int y)
    {
        if (x == heights.Length - 1 && y == heights[0].Length - 1)
            return true;
        
        visited[x, y] = true;
        for (int i = 0; i < 4; i++)
        {
            int nx = x + dx[i],
                ny = y + dy[i];
            
            if (nx >= 0 && nx < heights.Length &&
               ny >= 0 && ny < heights[0].Length &&
               !visited[nx, ny])
            {
                if (Math.Abs(heights[x][y] - heights[nx][ny]) <= threshold &&
                   CanFindPath(heights, visited, threshold, nx, ny))
                    return true;
            }
        }
        
        return false;
    }
}
// @lc code=end

