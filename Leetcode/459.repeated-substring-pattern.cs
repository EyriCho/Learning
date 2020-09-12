/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */

// @lc code=start
public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        if (s.Length == 1) return false;
        
        for (int i = 0; i < s.Length / 2; i++)
        {
            int length = i + 1;
            if (s.Length % length == 0)
            {
                int j = length;
                for (; j < s.Length; j++)
                {
                    if (s[j] != s[j % length])
                        break;
                }
            
                if (j == s.Length)
                    return true;                
            }
        }
        
        return false;
    }
}
// @lc code=end

