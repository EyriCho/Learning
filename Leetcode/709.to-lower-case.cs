/*
 * @lc app=leetcode id=709 lang=csharp
 *
 * [709] To Lower Case
 */

// @lc code=start
public class Solution {
    public string ToLowerCase(string s) {
        var array = s.ToCharArray();
        
        for (int i = 0; i < s.Length; i++)
            if (s[i] >= 'A' && s[i] <= 'Z')
                array[i] = (char)(array[i] + 32);
        
        return new string(array);
    }
}
// @lc code=end

