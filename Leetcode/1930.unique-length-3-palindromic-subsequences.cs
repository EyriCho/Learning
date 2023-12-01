/*
 * @lc app=leetcode id=1930 lang=csharp
 *
 * [1930] Unique Length-3 Palindromic Subsequences
 */

// @lc code=start
public class Solution {
    public int CountPalindromicSubsequence(string s) {
        int result = 0;

        for (char c = 'a'; c <= 'z'; c++)
        {
            int l = 0, r = s.Length - 1;
            while (l < s.Length && s[l] != c)
            {
                l++;
            }
            while (r > l && s[r] != c)
            {
                r--;
            }

            if (l + 1 >= r)
            {
                continue;
            }

            int m = l;
            bool[] visited = new bool[26];
            while (++m < r)
            {
                int cIndex = s[m] - 'a';
                if (!visited[cIndex])
                {
                    result++;
                    visited[cIndex] = true;
                }
            }
        }

        return result;
    }
}
// @lc code=end

