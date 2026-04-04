/*
 * @lc app=leetcode id=3567 lang=csharp
 *
 * [3567] Minimum Absolute Difference in Sliding Submatrix
 */

// @lc code=start
public class Solution {
    public int[][] MinAbsDiff(int[][] grid, int k) {
        int height = grid.Length - k + 1,
            width = grid[0].Length - k + 1;
        int[][] result = new int[height][];
        for (int i = 0; i < height; i++)
        {
            result[i] = new int[width];
        }
        if (k == 1)
        {
            return result;
        }

        int minDiff = int.MaxValue;
        HashSet<int> set = new ();
        List<int> list = null;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                set.Clear();
                for (int x = 0; x < k; x++)
                {
                    for (int y = 0; y < k; y++)
                    {
                        set.Add(grid[i + x][j + y]);
                    }
                }

                list = set.ToList();
                list.Sort();

                if (list.Count == 1)
                {
                    result[i][j] = 0;
                    continue;
                }
                minDiff = int.MaxValue;
                for (int l = 1; l < list.Count; l++)
                {
                    minDiff = Math.Min(minDiff, list[l] - list[l - 1]);
                }

                result[i][j] = minDiff;
            }
        }

        return result;
    }
}
// @lc code=end

