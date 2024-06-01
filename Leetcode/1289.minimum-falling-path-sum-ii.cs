/*
 * @lc app=leetcode id=1289 lang=csharp
 *
 * [1289] Minimum Falling Path Sum II
 */

// @lc code=start
public class Solution {
    public int MinFallingPathSum(int[][] grid) {
        int f = 0, s = 0,
            fi = -1,
            cf = 0, cs = 0,
            cfi = -1,
            sum = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            f = cf;
            s = cs;
            fi = cfi;
            cf = int.MaxValue;
            cs = int.MaxValue;
            cfi = -1;

            for (int j = 0; j < grid.Length; j++)
            {
                sum = (j == fi ? s : f) + grid[i][j];

                if (sum < cf)
                {
                    cs = cf;
                    cf = sum;
                    cfi = j;
                }
                else if (sum < cs)
                {
                    cs = sum;
                }
            }
        }

        return cf;    }
}
// @lc code=end

