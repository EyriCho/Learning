/*
 * @lc app=leetcode id=59 lang=csharp
 *
 * [59] Spiral Matrix II
 */

// @lc code=start
public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        
        int num = 0,
            l = 0, t = 0,
            b = n - 1, r = n - 1;
        while (l <= r && t <= b)
        {
            for (int j = l; j <= r; j++)
            {
                result[t][j] = ++num;
            }
            t++;
            
            for (int i = t; i <= b; i++)
            {
                result[i][r] = ++num;
            }
            r--;
            
            for (int j = r; j >= l; j--)
            {
                result[b][j] = ++num;
            }
            b--;
            
            for (int i = b; i >= t; i--)
            {
                result[i][l] = ++num;
            }
            l++;
        }
        
        return result;
    }
}
// @lc code=end

