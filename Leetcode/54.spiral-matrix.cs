/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 */

// @lc code=start
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        int l = 0, t = 0,
            b = matrix.Length - 1, r = matrix[0].Length - 1;
        while (l <= r && t <= b)
        {
            for (int j = l; j <= r; j++)
                result.Add(matrix[t][j]);
            t++;
            if (t > b)
                break;
            
            for (int i = t; i <= b; i++)
                result.Add(matrix[i][r]);
            r--;
            if (l > r)
                break;
            
            for (int j = r; j >= l; j--)
                result.Add(matrix[b][j]);
            b--;
            if (t > b)
                break;
            
            for (int i = b; i >= t; i--)
                result.Add(matrix[i][l]);
            l++;
        }
        
        return result;        
    }
}
// @lc code=end

