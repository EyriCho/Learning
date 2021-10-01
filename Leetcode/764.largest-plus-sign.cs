/*
 * @lc app=leetcode id=764 lang=csharp
 *
 * [764] Largest Plus Sign
 */

// @lc code=start
public class Solution {
    public int OrderOfLargestPlusSign(int n, int[][] mines) {
        if (n < 2)
            return 0;
        
        int[,] left = new int[n, n],
            right = new int[n, n],
            up = new int[n, n],
            down = new int[n, n];
        
        int last = n - 1;
        
        foreach (var mine in mines)
        {
            left[mine[0], mine[1]] = -1;
            right[mine[0], mine[1]] = -1;
            up[mine[0], mine[1]] = -1;
            down[mine[0], mine[1]] = -1;
        }
                
        for (int i = 1; i < last; i++)
            for (int j = 1; j < last; j++)
            {
                if (left[i, j] >= 0)
                    left[i, j] = left[i, j - 1] + 1;
                if (up[i, j] >= 0)
                    up[i, j] = up[i - 1, j] + 1;
            }
        
        for (int i = last - 1; i > 0; i--)
            for (int j = last - 1; j > 0; j--)
            {
                if (right[i, j] >= 0)
                    right[i, j] = right[i, j + 1] + 1;
                if (down[i, j] >= 0)
                    down[i, j] = down[i + 1, j] + 1;
            }
        
        var result = -1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                int h = Math.Min(left[i, j], right[i, j]),
                    v = Math.Min(up[i, j], down[i, j]);
                
                result = Math.Max(result, Math.Min(h, v));
            }
        
        return result + 1;
    }
}
// @lc code=end

