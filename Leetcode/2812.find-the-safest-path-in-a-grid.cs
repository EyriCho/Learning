/*
 * @lc app=leetcode id=2812 lang=csharp
 *
 * [2812] Find the Safest Path in a Grid
 */

// @lc code=start
public class Solution {
    public int MaximumSafenessFactor(IList<IList<int>> grid) {
        int[,] near = new int[grid.Count, grid.Count];
        int[,] directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 },
        };
        for (int i = 0; i < grid.Count; i++)
        {
            for (int j = 0; j < grid.Count; j++)
            {
                near[i, j] = -1;
            }
        }

        Queue<(int, int)> qNear = new ();
        for (int i = 0; i < grid.Count; i++)
        {
            for (int j = 0; j < grid.Count; j++)
            {
                if (grid[i][j] == 1)
                {
                    near[i, j] = 0;
                    qNear.Enqueue((i, j));
                }
            }
        }

        while (qNear.Count > 0)
        {
            (int x, int y) = qNear.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                int i = x + directions[k, 0],
                    j = y + directions[k, 1];
                
                if (i < 0 || i >= grid.Count ||
                    j < 0 || j >= grid.Count ||
                    near[i, j] > -1)
                {
                    continue;
                }

                near[i, j] = near[x, y] + 1;
                qNear.Enqueue((i, j));
            }
        }

        bool IsSafe(int d)
        {
            bool[,] visited = new bool[grid.Count, grid.Count];

            Queue<(int, int)> queue = new ();
            queue.Enqueue((0, 0));
            while (queue.Count > 0)
            {
                (int x, int y) = queue.Dequeue();
                if (x < 0 || x >= grid.Count ||
                    y < 0 || y >= grid.Count ||
                    near[x, y] < d)
                {
                    continue;
                }

                if (visited[x, y])
                {
                    continue;
                }
                visited[x, y] = true;

                if (x == grid.Count - 1 &&
                    y == grid.Count - 1)
                {
                    return true;
                }
                
                queue.Enqueue((x - 1, y));
                queue.Enqueue((x + 1, y));
                queue.Enqueue((x, y - 1));
                queue.Enqueue((x, y + 1));
            }

            return false;
        }

        int l = 0,
            r = Math.Min(near[0, 0], near[grid.Count - 1, grid.Count - 1]),
            m = 0;

        while (l < r)
        {
            m = (l + r + 1) / 2;

            if (IsSafe(m))
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}
// @lc code=end

