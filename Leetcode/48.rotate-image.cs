/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution {
    public void Rotate(int[][] matrix) {
        int l = 0, r = matrix.Length - 1,
            last = matrix.Length - 1;
        
        while (l < r)
        {
            for (int i = l; i < r; i++)
            {
                int temp = matrix[l][i];
                matrix[l][i] = matrix[last - i][l];
                matrix[last - i][l] = matrix[r][last - i];
                matrix[r][last - i] = matrix[i][r];
                matrix[i][r] = temp;
            }
            
            l++;
            r--;
        }
    }
}
// @lc code=end

