/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0, bottom = matrix.Length - 1,
            m = 0,
            row = 0;

        while (top <= bottom)
        {
            m = (top + bottom) >> 1;
            if (matrix[m][0] <= target)
            {
                top = m + 1;
                row = m;
            }
            else
            {
                bottom = m - 1;
            }
        }

        int left = 0, right = matrix[0].Length - 1;
        while (left <= right)
        {
            m = (left + right) >> 1;
            if (matrix[row][m] < target)
            {
                left = m + 1;
            }
            else if (matrix[row][m] > target)
            {
                right = m - 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

