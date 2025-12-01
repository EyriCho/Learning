/*
 * @lc app=leetcode id=2536 lang=csharp
 *
 * [2536] Increment Submatrices by One
 */

// @lc code=start
public class Solution {
    public int[][] RangeAddQueries(int n, int[][] queries) {
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        foreach (int[] query in queries)
        {
            for (int i = query[0]; i <= query[2]; i++)
            {
                result[i][query[1]]++;
                if (query[3] + 1 < n)
                {
                    result[i][query[3] + 1]--;
                }
            }
        }

        int sum  = 0;
        for (int i = 0; i < n; i++)
        {
            sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += result[i][j];
                result[i][j] = sum;
            }
        }

        return result; 
    }
}
// @lc code=end

