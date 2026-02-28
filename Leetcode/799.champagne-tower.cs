/*
 * @lc app=leetcode id=799 lang=csharp
 *
 * [799] Champagne Tower
 */

// @lc code=start
public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[] pyramid = new double[101];
        pyramid[0] = poured;

        double split = 0D;
        for (int r = 1; r <= query_row; r++)
        {
            for (int g = r - 1; g >= 0; g--)
            {
                split = Math.Max(0D, (pyramid[g] - 1D) / 2D);
                pyramid[g] = split;
                pyramid[g + 1] += split;
            }
        }

        return Math.Min(1D, pyramid[query_glass]);
    }
}
// @lc code=end

