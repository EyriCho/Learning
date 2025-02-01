/*
 * @lc app=leetcode id=1765 lang=csharp
 *
 * [1765] Map of Highest Peak
 */

// @lc code=start
public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int[][] result = new int[isWater.Length][];

        Queue<(int, int)> queue = new ();

        for (int i = 0; i < isWater.Length; i++)
        {
            result[i] = new int[isWater[0].Length];
            for (int j = 0; j < isWater[0].Length; j++)
            {
                if (isWater[i][j] == 1)
                {
                    queue.Enqueue((i, j));
                }
                else
                {
                    result[i][j] = -1;
                }
            }
        }

        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int x = 0,
            y = 0,
            nx = 0,
            ny = 0,
            h = 0;
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                nx = x + ds[i, 0];
                ny = y + ds[i, 1];
                if (nx >= 0 && nx < isWater.Length &&
                    ny >= 0 && ny < isWater[0].Length &&
                    result[nx][ny] == -1)
                {
                    result[nx][ny] = result[x][y] + 1;
                    queue.Enqueue((nx, ny));
                }
            }
        }

        return result;
    }
}
// @lc code=end

