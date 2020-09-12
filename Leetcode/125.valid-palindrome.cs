/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 0) return true;
        
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (!((s[l] >= 'A' && s[l] <= 'Z') ||
                (s[l] >= 'a' && s[l] <= 'z') ||
                (s[l] >= '0' && s[l] <= '9')))
            {
                l++;
                continue;
            }
            if (!((s[r] >= 'A' && s[r] <= 'Z') ||
                (s[r] >= 'a' && s[r] <= 'z') ||
                (s[r] >= '0' && s[r] <= '9')))
            {
                r--;
                continue;
            }
            char cl = s[l], rl = s[r];
            if (cl >= 'a' && cl <= 'z')
                cl = (char)(cl - 32);
            if (rl >= 'a' && rl <= 'z')
                rl = (char)(rl - 32);
            if (cl != rl)
                return false;
            l++;
            r--;
        }
        
        return true;        
    }
}
// @lc code=end

