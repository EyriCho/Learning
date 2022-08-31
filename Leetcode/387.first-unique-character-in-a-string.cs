/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution {
    public int FirstUniqChar(string s) {
        var chars = new int[26];
        Array.Fill(chars, -1);
        
        for (int i = 0; i < s.Length; i++)
        {
            var index = s[i] - 'a';
            
            if (chars[index] < 0)
            {
                chars[index] = i;
            }
            else
            {
                chars[index] = int.MaxValue;
            }
        }
        
        var result = int.MaxValue;
        for (int i = 0; i < 26; i++)
        {
            if (chars[i] >= 0)
            {
                result = Math.Min(result, chars[i]);
            }
        }
        
        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

