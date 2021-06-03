/*
 * @lc app=leetcode id=52 lang=csharp
 *
 * [52] N-Queens II
 */

// @lc code=start
public class Solution {
    public int TotalNQueens(int n) {
        var result = 0;
        var indexes = new int[n];
        
        bool IsWork(int row)
        {
            for (int i = 0; i < row; i++)
            {
                if (indexes[row] == indexes[i])
                    return false;
                
                if (indexes[i] + row - i == indexes[row])
                    return false;
                
                if (indexes[i] - row + i == indexes[row])
                    return false;
            }
            return true;
        }
        
        void Queens(int row)
        {
            if (row == n)
            {
                result++;
                return;
            }
            
            for (int i = 0; i < n; i++)
            {
                indexes[row] = i;
                if (IsWork(row))
                {
                    Queens(row + 1);
                }
            }
        }
        
        Queens(0);
        
        return result;
    }
}
// @lc code=end

