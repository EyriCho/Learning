/*
 * @lc app=leetcode id=680 lang=csharp
 *
 * [680] Valid Palindrome II
 */

// @lc code=start
public class Solution {
    public bool ValidPalindrome(string s) {
        bool Valid(string str)
        {
            int l = 0, r = str.Length - 1;
            
            while (l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
        
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return Valid(s[i..j]) || Valid(s[(i + 1)..(j + 1)]);
            }
            i++;
            j--;
        }
        
        return true;
    }
}
// @lc code=end

