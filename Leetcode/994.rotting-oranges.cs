/*
 * @lc app=leetcode id=994 lang=csharp
 *
 * [994] Rotting Oranges
 */

// @lc code=start
public class Solution {
    public int OrangesRotting(int[][] grid) {
        var queue = new Queue<(int, int)>();
        int result = -1;
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 2)
                    queue.Enqueue((i, j));
                else if (grid[i][j] == 1)
                    count++;
            }
        }
        
        if (count == 0) return 0;
        while (queue.Count() > 0)
        {
            var length = queue.Count();
            for (int index = 0; index < length; index++)
            {
                var (i, j) = queue.Dequeue();
                if (i > 0 && grid[i - 1][j] == 1)
                {
                    grid[i - 1][j] = 2;
                    queue.Enqueue((i - 1, j));
                    count--;
                }
                if (j > 0 && grid[i][j - 1] == 1)
                {
                    grid[i][j - 1] = 2;
                    queue.Enqueue((i, j - 1));
                    count--;
                }
                if (i < grid.Length - 1 && grid[i + 1][j] == 1)
                {
                    grid[i + 1][j] = 2;
                    queue.Enqueue((i + 1, j));
                    count--;
                }
                if (j < grid[i].Length - 1 && grid[i][j + 1] == 1)
                {
                    grid[i][j + 1] = 2;
                    queue.Enqueue((i, j + 1));
                    count--;
                }
            }
            
            result++;
        }
        
        return count > 0 ? -1 : result;
    }
}
// @lc code=end

