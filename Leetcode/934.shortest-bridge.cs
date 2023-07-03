/*
 * @lc app=leetcode id=934 lang=csharp
 *
 * [934] Shortest Bridge
 */

// @lc code=start
public class Solution {
    public int ShortestBridge(int[][] grid) {
        var directions = new int[][] {
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
        };

        var queue = new Queue<(int, int)>();

        void LocateFirstIsland(int i, int j)
        {
            grid[i][j] = -1;
            queue.Enqueue((i, j));

            foreach (var direction in directions)
            {
                int x = i + direction[0],
                    y = j + direction[1];

                if (x >= 0 && x < grid.Length &&
                    y >= 0 && y < grid[0].Length &&
                    grid[x][y] == 1)
                {
                    LocateFirstIsland(x, y);
                }
            }
        }


        var found = false;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    LocateFirstIsland(i, j);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                break;
            }
        }

        var bridge = 0;
        while (queue.Count > 0)
        {
            var count = queue.Count;

            while (count-- > 0)
            {
                var (i, j) = queue.Dequeue();

                foreach (var direction in directions)
                {
                    int x = i + direction[0],
                        y = j + direction[1];

                    if (x >= 0 && x < grid.Length &&
                        y >= 0 && y < grid[0].Length)
                    {
                        if (grid[x][y] > 0)
                        {
                            return bridge;
                        }
                        else if (grid[x][y] == 0)
                        {
                            queue.Enqueue((x, y));
                            grid[x][y] = -1;
                        }
                    }
                }
            }

            bridge++;
        }

        return bridge;
    }
}
// @lc code=end

