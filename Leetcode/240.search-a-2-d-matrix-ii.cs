/*
 * @lc app=leetcode id=240 lang=csharp
 *
 * [240] Search a 2D Matrix II
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int x = matrix.Length - 1,
            y = 0;
        
        while (x >= 0 && y < matrix[0].Length)
        {
            if (matrix[x][y] == target)
                return true;
            else if (matrix[x][y] > target)
                x--;
            else
                y++;
        }
        
        return false;
    }
}
// @lc code=end

