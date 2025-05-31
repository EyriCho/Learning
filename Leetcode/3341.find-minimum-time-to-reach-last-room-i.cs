/*
 * @lc app=leetcode id=3341 lang=csharp
 *
 * [3341] Find Minimum Time to Reach Last Room I
 */

// @lc code=start
public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int[,] dp = new int[moveTime.Length, moveTime[0].Length];
        for (int i = 0; i < moveTime.Length; i++)
        {
            for (int j = 0; j < moveTime[0].Length; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }
        dp[0, 0] = 0;

        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        PriorityQueue<(int, int), int> queue = new ();
        queue.Enqueue((0, 0), 0);

        int x = 0, y = 0,
            nx = 0, ny = 0, time = 0;
        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                nx = x + ds[i, 0];
                ny = y + ds[i, 1];

                if (nx < 0 || nx >= moveTime.Length ||
                    ny < 0 || ny >= moveTime[0].Length)
                {
                    continue;
                }

                time = Math.Max(dp[x, y] + 1, moveTime[nx][ny] + 1);
                if (time >= dp[nx, ny])
                {
                    continue;
                }
                
                dp[nx, ny] = time;
                queue.Enqueue((nx, ny), time);
            }
        }

        return dp[moveTime.Length - 1, moveTime[0].Length - 1];
    }
}
// @lc code=end

