/*
 * @lc app=leetcode id=1072 lang=csharp
 *
 * [1072] Flip Columns For Maximum Number of Equal Rows
 */

// @lc code=start
public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string, int> dict = new();
        char[] array = new char[matrix[0].Length],
            flipArray = new char[matrix[0].Length];
        string normal = null, flip = null;
        int n = 0, f = 0,
            result = 1;
        
        foreach (int[] row in matrix)
        {
            for (int i = 0; i < row.Length; i++)
            {
                array[i] = (char)(row[i] + '0');
                flipArray[i] = (char)(1 - row[i] + '0');
            }

            normal = new string(array);
            flip = new string(flipArray);

            dict.TryGetValue(normal, out n);
            dict.TryGetValue(flip, out f);

            result = Math.Max(result, n + f + 1);
            dict[normal] = n + 1;
        }

        return result;
    }
}
// @lc code=end

