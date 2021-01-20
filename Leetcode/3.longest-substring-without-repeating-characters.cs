/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dict = new Dictionary<char, int>();
        
        int lastDuplicate = -1,
            result = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                lastDuplicate = Math.Max(lastDuplicate, dict[s[i]]);
            }
            
            result = Math.Max(result, i - lastDuplicate);
            dict[s[i]] = i;
        }
        
        return result;
    }
}
// @lc code=end

