/*
 * @lc app=leetcode id=3212 lang=csharp
 *
 * [3212] Count Submatrices With Equal Frequency of X and Y
 */

// @lc code=start
public class Solution {
    public int NumberOfSubmatrices(char[][] grid) {
        int[,] prev = new int[grid[0].Length, 3],
            curr = new int[grid[0].Length, 3],
            temp = null;
        
        int result = 0;

        int GetValue(int i, int j)
        {
            return grid[i][j] switch
            {
                'X' => 0,
                'Y' => 1,
                _ => 2,
            };
        }

        curr[0, GetValue(0, 0)]++;
        for (int j = 1; j < grid[0].Length; j++)
        {
            curr[j, 0] = curr[j - 1, 0];
            curr[j, 1] = curr[j - 1, 1];
            curr[j, GetValue(0, j)]++;
            if (curr[j, 0] > 0 && curr[j, 0] == curr[j, 1])
            {
                result++;
            }
        }

        for (int i = 1; i < grid.Length; i++)
        {
            temp = prev;
            prev = curr;
            curr = temp;
            for (int j = 0; j < grid[0].Length; j++)
            {
                curr[j, 0] = prev[j, 0];
                curr[j, 1] = prev[j, 1];
                if (j != 0)
                {
                    curr[j, 0] += curr[j - 1, 0] - prev[j - 1, 0];
                    curr[j, 1] += curr[j - 1, 1] - prev[j - 1, 1];
                }
                curr[j, GetValue(i, j)]++;

                if (curr[j, 0] > 0 && curr[j, 0] == curr[j, 1])
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

