/*
 * @lc app=leetcode id=3756 lang=csharp
 *
 * [3756] Concatenate Non-Zero Digits and Multiply by Sum II
 */

// @lc code=start
public class Solution {
    public int[] SumAndMultiply(string s, int[][] queries) {
        const long mod = 1_000_000_007L;
        long[] pow10 = new long[100_001];
        pow10[0] = 1L;
        for (int i = 1; i < pow10.Length; i++)
        {
            pow10[i] = (pow10[i - 1] * 10L) % mod;
        }

        int digit = 0;
        (int sum, long x, int count)[] prefix = new (int, long, int)[s.Length + 1];
        for (int i = 0; i < s.Length; i++)
        {
            digit = s[i] - '0';
            prefix[i + 1] = (
                prefix[i].sum + digit,
                digit > 0 ? ((prefix[i].x * 10L + digit) % mod) : prefix[i].x,
                prefix[i].count + (digit > 0 ? 1 : 0)
            );
        }

        int[] result = new int[queries.Length];
        int l = 0, r = 0, length = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            l = queries[i][0];
            r = queries[i][1] + 1;
            length = prefix[r].count - prefix[l].count;
            result[i] = (int)((prefix[r].sum - prefix[l].sum) *
                (prefix[r].x - prefix[l].x * pow10[length] % mod + mod) %
                mod);
        }

        return result;
    }
}
// @lc code=end

