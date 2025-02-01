/*
 * @lc app=leetcode id=407 lang=csharp
 *
 * [407] Trapping Rain Water II
 */

// @lc code=start
public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        if (heightMap.Length <= 2 ||
            heightMap[0].Length <= 2)
        {
            return 0;
        }

        int lastM = heightMap.Length - 1,
            lastN = heightMap[0].Length - 1;
        bool[,] visited = new bool[heightMap.Length, heightMap[0].Length];
        PriorityQueue<(int, int), int> queue = new ();

        for (int i = 0; i < heightMap.Length; i++)
        {
            visited[i, 0] = true;
            queue.Enqueue((i, 0), heightMap[i][0]);
            visited[i, lastN] = true;
            queue.Enqueue((i, lastN), heightMap[i][lastN]);
        }

        for (int j = 0; j < heightMap[0].Length; j++)
        {
            visited[0, j] = true;
            queue.Enqueue((0, j), heightMap[0][j]);
            visited[lastM, j] = true;
            queue.Enqueue((lastM, j), heightMap[lastM][j]);
        }

        int x = 0,
            y = 0,
            nx = 0,
            ny = 0,
            result = 0;
        
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                nx = x + ds[i, 0];
                ny = y + ds[i, 1];

                if (nx >= 0 && nx < heightMap.Length &&
                    ny >= 0 && ny < heightMap[0].Length &&
                    !visited[nx, ny])
                {
                    visited[nx, ny] = true;
                    if (heightMap[nx][ny] < heightMap[x][y])
                    {
                        result += heightMap[x][y] - heightMap[nx][ny];
                        heightMap[nx][ny] = heightMap[x][y];
                    }
                    queue.Enqueue((nx, ny), heightMap[nx][ny]);
                }
            }
        }

        return result;
    }
}
// @lc code=end

