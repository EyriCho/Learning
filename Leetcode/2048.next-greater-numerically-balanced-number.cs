/*
 * @lc app=leetcode id=2048 lang=csharp
 *
 * [2048] Next Greater Numerically Balanced Number
 */

// @lc code=start
public class Solution {
    public int NextBeautifulNumber(int n) {
        if (n == 1_000_000)
        {
            return 1_224_444;
        }
        int[] balances = new int[] {
            0,
            1,
            22,
            122,
            1333,
            14444,
            122333,
            1224444,
        };
        int[][][] ways = new int[][][] {
            // 0 digit
            new int[0][],
            // 1 digit
            new int[][] {
                new int[] { 0, 1, },
            },
            // 2 digit
            new int[][] {
                new int[] { 0, 0, 2, },
            },
            // 3 digit
            new int[][] {
                new int[] { 0, 1, 2, },
                new int[] { 0, 0, 0, 3, },
            },
            // 4 digit
            new int[][] {
                new int[] { 0, 1, 0, 3, },
                new int[] { 0, 0, 0, 0, 4, },
            },
            // 5 digit
            new int[][] {
                new int[] { 0, 1, 0, 0, 4, },
                new int[] { 0, 0, 2, 3, },
                new int[] { 0, 0, 0, 0, 0, 5, },
            },
            // 6 digit
            new int[][] {
                new int[] { 0, 1, 2, 3, 0, 0, },
                new int[] { 0, 1, 0, 0, 0, 5, },
                new int[] { 0, 0, 2, 0, 4, },
                new int[] { 0, 0, 0, 0, 0, 0, 6, },
            },
        };

        int count = 0,
            num = n;
        while (num > 0)
        {
            count++;
            num /= 10;
        }

        List<int> list = new ();
        void Dfs(int[] digits, int current, int c)
        {
            if (c == count)
            {
                list.Add(current);
            }

            for (int d = 0; d < digits.Length; d++)
            {
                if (digits[d] == 0)
                {
                    continue;
                }

                digits[d]--;
                Dfs(digits, current * 10 + d, c + 1);
                digits[d]++;
            }
        }

        foreach (int[] digits in ways[count])
        {
            Dfs(digits, 0, 0);
        }
        list.Add(balances[count + 1]);
        list.Sort();

        int l = 0, r = list.Count, m = 0;
        while (l < r)
        {
            m = (l + r) >> 1;
            if (list[m] <= n)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return list[l];
    }
}
// @lc code=end

