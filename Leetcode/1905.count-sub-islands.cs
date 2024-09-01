/*
 * @lc app=leetcode id=1905 lang=csharp
 *
 * [1905] Count Sub Islands
 */

// @lc code=start
public class Solution {
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        int result = 0;
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };
        Queue<(int, int)> queue = new ();

        int SubIsland()
        {
            int rst = 1;
            int x = 0,
                y = 0,
                i = 0,
                j = 0;
            while (queue.Count > 0)
            {
                (x, y) = queue.Dequeue();
                if (grid1[x][y] == 0)
                {
                    rst = 0;
                }

                for (int k = 0; k < ds.GetLength(0); k++)
                {
                    i = x + ds[k, 0];
                    j = y + ds[k, 1];
                    if (i >= 0 && i < grid2.Length &&
                        j >= 0 && j < grid2[0].Length &&
                        grid2[i][j] == 1)
                    {
                        grid2[i][j] = 2;
                        queue.Enqueue((i ,j));
                    }
                }
            }

            return rst;
        }

        for (int i = 0; i < grid2.Length; i++)
        {
            for (int j = 0; j < grid2[0].Length; j++)
            {
                if (grid2[i][j] == 1)
                {
                    queue.Enqueue((i, j));
                    result += SubIsland();
                }
            }
        }

        return result;
    }
}
// @lc code=end

