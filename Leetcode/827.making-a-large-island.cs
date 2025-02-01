/*
 * @lc app=leetcode id=827 lang=csharp
 *
 * [827] Making A Large Island
 */

// @lc code=start
public class Solution {
    public int LargestIsland(int[][] grid) {
        Dictionary<int, int> dict = new ();
        int id = 1,
            nx = 0,
            ny = 0;
        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        void Travel(int x, int y, int identity)
        {
            dict[identity]++;
            grid[x][y] = identity;
            for (int i = 0; i < 4; i++)
            {
                nx = x + ds[i, 0];
                ny = y + ds[i, 1];
                if (nx >= 0 && nx < grid.Length &&
                    ny >= 0 && ny < grid.Length &&
                    grid[nx][ny] == 1)
                {
                    Travel(nx, ny, identity);
                }
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    dict[++id] = 0;
                    Travel(i, j, id);
                }
            }
        }

        if (dict.Count == 0)
        {
            return 1;
        }

        HashSet<int> set = new ();
        int max = 0, sum = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[i][j] != 0)
                {
                    continue;
                }
                set.Clear();
                sum = 1;
                for (int k = 0; k < 4; k++)
                {
                    nx = i + ds[k, 0];
                    ny = j + ds[k, 1];
                    if (nx >= 0 && nx < grid.Length &&
                        ny >= 0 && ny < grid.Length &&
                        grid[nx][ny] > 1)
                    {
                        if (set.Contains(grid[nx][ny]))
                        {
                            continue;
                        }
                        set.Add(grid[nx][ny]);
                        sum += dict[grid[nx][ny]];
                    }
                }
                max = Math.Max(max, sum);
            }
        }

        return max == 0 ? grid.Length * grid.Length : max;
    }
}
// @lc code=end

