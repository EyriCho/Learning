/*
 * @lc app=leetcode id=2438 lang=csharp
 *
 * [2438] Range Product Queries of Powers
 */

// @lc code=start
public class Solution {
    public int[] ProductQueries(int n, int[][] queries) {
        List<int> powers = new ();
        int power = 0,
            length = 0;
        while (n > 0)
        {
            power = n & -n;
            powers.Add(power);
            n ^= power;
        }

        long[,] tables = new long[powers.Count, powers.Count];
        for (int i = 0; i < powers.Count; i++)
        {
            tables[i, i] = powers[i];
            for (int j = i + 1; j < powers.Count; j++)
            {
                tables[i, j] = tables[i, j - 1] * powers[j] % 1_000_000_007L;
            }
        }

        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = (int)tables[queries[i][0], queries[i][1]];
        }

        return result;
    }
}
// @lc code=end

