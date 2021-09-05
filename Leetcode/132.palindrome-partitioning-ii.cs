/*
 * @lc app=leetcode id=132 lang=csharp
 *
 * [132] Palindrome Partitioning II
 */

// @lc code=start
public class Solution {
    public int MinCut(string s) {
        var dp = new bool[s.Length, s.Length];
        var counts = new int[s.Length + 1];
        
        for (int i = s.Length - 1; i > -1; i--)
        {
            counts[i] = int.MaxValue;
            for (int j = i; j < s.Length; j++)
                if (s[i] == s[j] && (j - i < 2 || dp[i + 1, j - 1]))
                {
                    dp[i, j] = true;
                    counts[i] = Math.Min(counts[j + 1] + 1, counts[i]);
                }
        }
        
        return counts[0] - 1;
    }
}
// @lc code=end

