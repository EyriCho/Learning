/*
 * @lc app=leetcode id=498 lang=csharp
 *
 * [498] Diagonal Traverse
 */

// @lc code=start
public class Solution {
    public int[] FindDiagonalOrder(int[][] matrix) {
        if (matrix.Length == 0)
            return new int[0];
        
        var size = matrix.Length * matrix[0].Length;
        var result = new int[size];
        
        int x = 0, y = 0,
            dx = -1, dy = 1, i = 0;
        
        while (i < size)
        {
            result[i++] = matrix[x][y];
                
            
            x += dx;
            y += dy;
            
            if (x < 0)
            {
                x++;
                if (y == matrix[0].Length)
                {
                    y--;
                    x++;
                }
                dx = 1;
                dy = -1;
            }
            else if (y < 0)
            {
                y++;
                if (x == matrix.Length)
                {
                    x--;
                    y++;
                }
                dx = -1;
                dy = 1;
            }
            else if (x == matrix.Length)
            {
                x--;
                y += 2;
                dx = -1;
                dy = 1;
            }
            else if (y == matrix[0].Length)
            {
                y--;
                x += 2;
                dx = 1;
                dy = -1;
            }
        }
        
        return result;
    }
}
// @lc code=end

