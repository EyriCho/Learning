/*
 * @lc app=leetcode id=940 lang=csharp
 *
 * [940] Distinct Subsequences II
 */

// @lc code=start
public class Solution {
    public int DistinctSubseqII(string s) {
        long[] last = new long[26];

        long result = 1L,
            prev = 1L,
            mod = 1_000_000_007L;
        int idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            idx = s[i] - 'a';
            result = ((prev << 1) + mod - last[idx]) % mod;
            last[idx] = prev;
            prev = result;
        }

        return (int)((result - 1 + mod) % mod);
    }
}
// @lc code=end

