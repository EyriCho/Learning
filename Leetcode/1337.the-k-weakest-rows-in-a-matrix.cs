/*
 * @lc app=leetcode id=1337 lang=csharp
 *
 * [1337] The K Weakest Rows in a Matrix
 */

// @lc code=start
public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var barrels = new List<int>[101];
        
        for (int i = 0; i < mat.Length; i++)
        {
            int j = 0, count = 0;
            while (j < mat[i].Length && mat[i][j] > 0)
            {
                count++;
                j++;
            }
            
            if (barrels[count] == null)
            {
                barrels[count] = new List<int>();
            }
            
            barrels[count].Add(i);
        }
        
        var result = new int[k];
        int idx = 0;
        for (int i = 0; i < 101; i++)
        {
            if (barrels[i] != null)
            {
                var num = Math.Min(k, barrels[i].Count);
                
                for (int j = 0; j < num; j++)
                {
                    result[idx++] = barrels[i][j];
                }
                
                k -= num;
                if (k == 0)
                {
                    break;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

