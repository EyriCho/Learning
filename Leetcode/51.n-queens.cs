/*
 * @lc app=leetcode id=51 lang=csharp
 *
 * [51] N-Queens
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>(n);
        var array = new char[n];
        Array.Fill(array, '.');
        
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
                var list = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    array[indexes[j]] = 'Q';
                    list.Add(new string(array));
                    array[indexes[j]] = '.';
                }
                result.Add(list);
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

