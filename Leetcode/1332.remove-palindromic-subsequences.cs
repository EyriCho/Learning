/*
 * @lc app=leetcode id=1332 lang=csharp
 *
 * [1332] Remove Palindromic Subsequences
 */

// @lc code=start
public class Solution {
    public int RemovePalindromeSub(string s) {
        if (s.Length == 0)
            return 0;
        
        int l = 0, r = s.Length - 1;
        while (l < r)
            if (s[l++] != s[r--])
                return 2;
        
        return 1;
    }
}
// @lc code=end

