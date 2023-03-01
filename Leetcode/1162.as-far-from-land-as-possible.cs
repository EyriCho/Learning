/*
 * @lc app=leetcode id=1162 lang=csharp
 *
 * [1162] As Far from Land as Possible
 */

// @lc code=start
public class Solution {
    public int MaxDistance(int[][] grid) {
        var queue = new Queue<(int, int)>();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] > 0)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        var directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };
        
        var round = -1;
        while (queue.Count > 0)
        {
            round++;

            var count = queue.Count;
            while (count--  > 0)
            {
                var (x, y) = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int x1 = x + directions[i, 0],
                        y1 = y + directions[i, 1];

                    if (x1 < 0 || x1 >= grid.Length ||
                        y1 < 0 || y1 >= grid[0].Length)
                    {
                        continue;
                    }

                    if (grid[x1][y1] == 0)
                    {
                        queue.Enqueue((x1, y1));
                        grid[x1][y1] = 1;
                    }
                }
            }
        }

        return round > 0 ? round : -1;
    }
}
// @lc code=end

