/*
 * @lc app=leetcode id=1926 lang=csharp
 *
 * [1926] Nearest Exit from Entrance in Maze
 */

// @lc code=start
public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var directions = new int[][] {
            new int[] { -1, 0 },
            new int[] { 0, -1 },
            new int[] { 1, 0 },
            new int[] { 0, 1 }
        };
        var visited = new bool[maze.Length, maze[0].Length];
        
        var step = 0;
        var queue = new Queue<(int, int)>();
        queue.Enqueue((entrance[0], entrance[1]));
        
        while (queue.Count > 0)
        {
            var count = queue.Count;
            while (count-- > 0)
            {
                var (x, y) = queue.Dequeue();
                
                if (visited[x, y])
                {
                    continue;
                }
                
                visited[x, y] = true;
                if (x == 0 || x == maze.Length - 1 ||
                    y == 0 || y == maze[0].Length - 1)
                {
                    if (step > 0)
                    {
                        return step;
                    }
                }
                
                foreach (var direction in directions)
                {
                    int i = x + direction[0],
                        j = y + direction[1];
                    
                    if (i >= 0 && i < maze.Length &&
                        j >= 0 && j < maze[0].Length &&
                        maze[i][j] == '.')
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }
            step++;
        }
        
        return -1;
    }
}
// @lc code=end

