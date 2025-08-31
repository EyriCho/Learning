/*
 * @lc app=leetcode id=498 lang=csharp
 *
 * [498] Diagonal Traverse
 */

// @lc code=start
public class Solution {
    public int[] FindDiagonalOrder(int[][] matrix) {
        int[] result = new int[mat.Length * mat[0].Length];

        int i = 0,
            x = 0, y = 0,
            dx = -1, dy = 1;
        
        while (i < result.Length)
        {
            result[i++] = mat[x][y];

            x += dx;
            y += dy;

            if (x < 0)
            {
                x = 0;
                if (y == mat[0].Length)
                {
                    y = mat[0].Length - 1;
                    x = 1;
                }
                dx = 1;
                dy = -1;
            }
            else if (y < 0)
            {
                y = 0;
                if (x == mat.Length)
                {
                    x = mat.Length - 1;
                    y = 1;
                }
                dx = -1;
                dy = 1;
            }
            else if (x == mat.Length)
            {
                x = mat.Length - 1;
                y += 2;
                dx = -1;
                dy = 1;
            }
            else if (y == mat[0].Length)
            {
                x += 2;
                y = mat[0].Length - 1;
                dx = 1;
                dy = -1;
            }
        }

        return result;
    }
}
// @lc code=end

