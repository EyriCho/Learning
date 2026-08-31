/*
 * @lc app=leetcode id=2904 lang=csharp
 *
 * [2904] Shortest and Lexicographically Smallest Beautiful String
 */

// @lc code=start
public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int count = 0,
            length = 0;
        string result = string.Empty;

        for (int l = 0, r = 0; l < s.Length; l++)
        {
            while (r < s.Length &&
                count < k)
            {
                count += s[r++] - '0';
            }

            if (count < k)
            {
                break;
            }

            length = r - l;
            if (result == string.Empty ||
                length < result.Length ||
                (length == result.Length && 
                string.Compare(s[l..r], result) < 0))
            {
                result = s[l..r];
            }

            count -= s[l] - '0';
        }

        return result;
    }
}
// @lc code=end

