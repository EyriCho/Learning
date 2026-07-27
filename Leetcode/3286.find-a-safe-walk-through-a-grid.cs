/*
 * @lc app=leetcode id=3286 lang=csharp
 *
 * [3286] Find a Safe Walk Through a Grid
 */

// @lc code=start
public class Solution {
    public bool FindSafeWalk(IList<IList<int>> grid, int health) {
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int[,] dp = new int[grid.Count, grid[0].Count];
        dp[0, 0] = health - grid[0][0];
        if (dp[0, 0] < 1)
        {
            return false;
        }

        PriorityQueue<(int, int), int> queue = new (Comparer<int>.Create((a, b) => b.CompareTo(a)));
        queue.Enqueue((0, 0), dp[0, 0]);

        int h = 0,
            nx = 0, ny = 0;
        (int x, int y) pos;
        while (queue.Count > 0)
        {
            queue.TryDequeue(out pos, out h);

            if (pos.x == grid.Count - 1 &&
                pos.y == grid[0].Count - 1)
            {
                return true;
            }

            for (int d = 0; d < 4; d++)
            {
                nx = pos.x + ds[d, 0];
                ny = pos.y + ds[d, 1];

                if (nx >= 0 && nx < grid.Count &&
                    ny >= 0 && ny < grid[0].Count &&
                    h - grid[nx][ny] > dp[nx, ny])
                {
                    dp[nx, ny] = h - grid[nx][ny];
                    queue.Enqueue((nx, ny), dp[nx, ny]);
                }
            }
        }

        return false;
    }
}
// @lc code=end

