/*
 * @lc app=leetcode id=3495 lang=csharp
 *
 * [3495] Minimum Operations to Make Array Elements Zero
 */

// @lc code=start
public class Solution {
    public long MinOperations(int[][] queries) {
        long result = 0L,
            start = 0L,
            end = 0L,
            basement = 0L,
            ops = 0L,
            l = 0L,
            r = 0L;
        foreach (int[] query in queries)
        {
            start = query[0];
            end = query[1];
            basement = 1L;
            ops = 0L;
            for (int op = 1; op < 20; op++)
            {
                l = Math.Max(start, basement);
                r = Math.Min(end, (basement << 2) - 1);

                if (l <= r)
                {
                    ops += (r - l + 1) * op;
                }

                basement <<= 2;
            }

            result += (ops + 1) >> 1;
        }
        return result;
    }
}
// @lc code=end

