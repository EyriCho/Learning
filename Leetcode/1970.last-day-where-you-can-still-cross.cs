/*
 * @lc app=leetcode id=1970 lang=csharp
 *
 * [1970] Last Day Where You Can Still Cross
 */

// @lc code=start
public class Solution {
    public int LatestDayToCross(int row, int col, int[][] cells) {
        var map = new bool[row, col];
        var group = new int[cells.Length + 2];
        for (int i = 0; i < cells.Length + 2; i++)
        {
            group[i] = i;
        }

        int FindGroup(int idx)
        {
            if (group[idx] == idx)
            {
                return idx;
            }

            return group[idx] = FindGroup(group[idx]);
        }

        void Grouping(int idx1, int idx2)
        {
            int g1 = FindGroup(idx1),
                g2 = FindGroup(idx2);
            
            if (g1 < g2)
            {
                group[g2] = g1;
            }
            else if (g1 > g2)
            {
                group[g1] = g2;
            }
        }

        var directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        for (int i = cells.Length - 1; i >= 0; i--)
        {
            int x = cells[i][0] - 1,
                y = cells[i][1] - 1;
            map[x, y] = true;

            var idx = x * col + y;
            for (int d = 0; d < 4; d++)
            {
                int x1 = x + directions[d, 0],
                    y1 = y + directions[d, 1];

                if (x1 < 0 || x1 >= row ||
                    y1 < 0 || y1 >= col ||
                    !map[x1, y1])
                {
                    continue;
                }

                Grouping(idx, x1 * col + y1);
            }

            if (cells[i][0] == 1)
            {
                Grouping(idx, cells.Length);
            }
            if (cells[i][0] == row)
            {
                Grouping(idx, cells.Length + 1);
            }
            if (FindGroup(cells.Length) == FindGroup(cells.Length + 1))
            {
                return i;
            }
        }

        return 0;
    }
}
// @lc code=end

