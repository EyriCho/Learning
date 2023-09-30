/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */

// @lc code=start
public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0)
        {
            return true;
        }
        if (s.Length > t.Length)
        {
            return false;
        }
        
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }
            j++;
        }
        
        return i == s.Length;
    }
}
// @lc code=end

