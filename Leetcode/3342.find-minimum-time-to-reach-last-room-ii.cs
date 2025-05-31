/*
 * @lc app=leetcode id=3342 lang=csharp
 *
 * [3342] Find Minimum Time to Reach Last Room II
 */

// @lc code=start
public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };
        
        int[,] steps = new int[moveTime.Length, moveTime[0].Length];
        for (int i = 0; i < moveTime.Length; i++)
        {
            for (int j = 0; j < moveTime[0].Length; j++)
            {
                steps[i, j] = - 1;
            }
        }
        steps[0, 0] = 2;

        PriorityQueue<(int, int, int), int> queue = new ();
        queue.Enqueue((0, 0, 0), 0);

        int x = 0, y = 0,
            nx = 0, ny = 0,
            t = 0, time = 0, travelTime = 1;
        while (queue.Count > 0)
        {
            (x, y, t) = queue.Dequeue();
            travelTime = 3 - steps[x, y];

            for (int i = 0; i < 4; i++)
            {
                nx = x + ds[i, 0];
                ny = y + ds[i, 1];

                if (nx < 0 || nx >= moveTime.Length ||
                    ny < 0 || ny >= moveTime[0].Length ||
                    steps[nx, ny] > 0)
                {
                    continue;
                }

                time = Math.Max(t, moveTime[nx][ny]) + travelTime;

                if (nx == moveTime.Length - 1 &&
                    ny == moveTime[0].Length - 1)
                {
                    return time;
                }

                steps[nx, ny] = travelTime;
                queue.Enqueue((nx, ny, time), time);
            }
        }

        return -1;
    }
}
// @lc code=end

