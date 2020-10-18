/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return false;
        
        int l = 0, h = matrix.Length - 1, m = 0;
        while (l <= h)
        {
            m = (l + h) / 2;
            if (target > matrix[m][0])
                l = m + 1;
            else if (target < matrix[m][0])
                h = m - 1;
            else
                return true;
        }
        
        if (target < matrix[m][0])
            if (m == 0)
                return false;
            else
                m--;
        
        l = 1;
        h = matrix[0].Length - 1;
        int i = 0;
        while (l <= h)
        {
            i = (l + h) / 2;
            if (target > matrix[m][i])
                l = i + 1;
            else if (target < matrix[m][i])
                h = i - 1;
            else
                return true; 
        }
        return false;
    }
}
// @lc code=end

