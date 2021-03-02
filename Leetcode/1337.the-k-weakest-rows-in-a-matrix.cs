/*
 * @lc app=leetcode id=1337 lang=csharp
 *
 * [1337] The K Weakest Rows in a Matrix
 */

// @lc code=start
public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int[] result = new int[k];
        int[][] temp = new int[mat.Length][];
        
        for (int i = 0; i < mat.Length; i++)
        {
            temp[i] = new int[2];
            int j = 0;
            while (j < mat[i].Length && mat[i][j] > 0)
                j++;
                
            temp[i][0] = j;
            temp[i][1] = i;
        }
        
        Sort(temp, k);
        
        for (int i = 0; i < k; i++)
        {
            result[i] = temp[i][1];
        }
        
        return result;
    }
    
    private void Sort(int[][] a, int k)
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = a.Length - 1; j > i; j--)
            {
                if (a[j][0] < a[j - 1][0])
                {
                    int[] swap = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = swap;
                }
            }
        }
    }
}
// @lc code=end

