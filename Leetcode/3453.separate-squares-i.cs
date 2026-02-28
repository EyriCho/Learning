/*
 * @lc app=leetcode id=3453 lang=csharp
 *
 * [3453] Separate Squares I
 */

// @lc code=start
public class Solution {
    public double SeparateSquares(int[][] squares) {
        double bottom = 0D,
            top = 1_000_000_000D,
            middle = 0D,
            areas = 0D;
        
        foreach (int[] square in squares)
        {
            areas += (double)square[2] * square[2];
        }

        double TopDownDiff(double line)
        {
            double a = 0D;
            foreach (int[] square in squares)
            {
                if (square[1] >= line)
                {
                    continue;
                }

                a += square[2] * Math.Min(square[2], line - square[1]);

            }

            return areas - a * 2;
        }

        while (top - bottom > 0.00001)
        {
            middle = (bottom + top) / 2D;
           
            if (TopDownDiff(middle) > 0)
            {
                bottom = middle;
            }
            else
            {
                top = middle;
            }
        }

        return top;
    }
}
// @lc code=end

