/*
 * @lc app=leetcode id=2370 lang=csharp
 *
 * [2370] Longest Ideal Subsequence
 */

// @lc code=start
public class Solution {
    public int LongestIdealString(string s, int k) {
        int[] dp = new int[26];
        int current = 0,
            index = 0,
            l = 0,
            r = 0;

        for (int i = 0; i < s.Length; i++)
        {
            current = 1;
            index = s[i] - 'a';
            l = Math.Max(0, index - k);
            r = Math.Min(25, index + k);
            for (int j = l; j <= r; j++)
            {
                current = Math.Max(current, dp[j] + 1);
            }
            dp[index] = current;
        }

        return dp.Max();
    }
}
// @lc code=end

