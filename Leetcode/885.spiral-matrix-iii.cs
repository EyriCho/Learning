/*
 * @lc app=leetcode id=885 lang=csharp
 *
 * [885] Spiral Matrix III
 */

// @lc code=start
public class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
        int total = rows * cols;
        int[][] result = new int[total][];

        int[,] directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };
        int count = 0,
            side = 1,
            d = 0;
        while (count < total)
        {
            for (int i = 0 ; i < 2; i++)
            {
                for (int s = 0; s < side; s++)
                {
                    if (0 <= rStart && rStart < rows &&
                        0 <= cStart && cStart < cols)
                    {
                        result[count++] = new int[] { rStart, cStart };
                    }
                    
                    rStart += directions[d, 0];
                    cStart += directions[d, 1];
                }
                d = (d + 1) % 4;
            }
            side++;
        }

        return result;
    }
}
// @lc code=end

