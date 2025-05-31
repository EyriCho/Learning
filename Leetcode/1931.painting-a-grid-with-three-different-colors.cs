/*
 * @lc app=leetcode id=1931 lang=csharp
 *
 * [1931] Painting a Grid With Three Different Colors
 */

// @lc code=start
public class Solution {
    public int ColorTheGrid(int m, int n) {
        List<int> cols = new ();
        void GenerateColumns(int pos, int prev, int curr)
        {
            if (pos == m)
            {
                cols.Add(curr);
                return ;
            }

            for (int c = 0; c < 3; c++)
            {
                if (c == prev)
                {
                    continue;
                }

                GenerateColumns(pos + 1, c, curr * 3 + c);
            }
        }

        GenerateColumns(0, -1, 0);

        List<int>[] translation = new List<int>[cols.Count];
        for (int i = 0; i < cols.Count; i++)
        {
            translation[i] = new ();
        }
        bool anyMatch = false;
        int a = 0, b = 0;
        for (int i = 0; i < cols.Count; i++)
        {
            for (int j = i + 1; j < cols.Count; j++)
            {
                anyMatch = false;
                a = cols[i];
                b = cols[j];
                for (int k = 0; k < m; k++)
                {
                    if (a % 3 == b % 3)
                    {
                        anyMatch = true;
                        break;
                    }
                    a /= 3;
                    b /= 3;
                }
                if (!anyMatch)
                {
                    translation[i].Add(j);
                    translation[j].Add(i);
                }
            }
        }

        long[] dp = Enumerable.Repeat(1L, cols.Count).ToArray(),
            next = new long[cols.Count],
            temp = null;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < cols.Count; j++)
            {
                foreach (int t in translation[j])
                {
                    next[t] = (next[t] + dp[j]) % 1_000_000_007L;
                }
            }
            temp = dp;
            dp = next;
            next = temp;
            Array.Clear(next);
        }

        long result = 0L;
        for (int i = 0; i < cols.Count; i++)
        {
            result = (result + dp[i]) % 1_000_000_007L;
        }

        return (int)result;
    }
}
// @lc code=end

