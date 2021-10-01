/*
 * @lc app=leetcode id=917 lang=csharp
 *
 * [917] Reverse Only Letters
 */

// @lc code=start
public class Solution {
    public string ReverseOnlyLetters(string s) {
        int l = 0, r = s.Length - 1;
        var array = s.ToCharArray();
        
        while (l < r)
        {
            char c = (char)(s[l] | ' ');
            while (!(c >= 'a' && c <= 'z') && l < r)
            {
                l++;
                c = (char)(s[l] | ' ');
            }
            
            c = (char)(s[r] | ' ');
            while (!(c >= 'a' && c <= 'z') && l < r)
            {
                r--;
                c = (char)(s[r] | ' ');
            }
            
            if (l < r)
            {
                c = array[l];
                array[l] = array[r];
                array[r] = c;
                l++;
                r--;
            }
        }
        
        return new string(array);
    }
}
// @lc code=end

