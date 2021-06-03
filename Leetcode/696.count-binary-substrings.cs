/*
 * @lc app=leetcode id=696 lang=csharp
 *
 * [696] Count Binary Substrings
 */

// @lc code=start
public class Solution {
    public int CountBinarySubstrings(string s) {
        var c = s[0];
        int prevCount = 0, count = 1,
            result = 0;
        
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == c)
                count++;
            else
            {
                c = s[i];
                prevCount = count;
                count = 1;
            }
            if (prevCount > 0)
            {
                prevCount--;
                result++;
            }
        }
        
        
        return result;
    }
}
// @lc code=end

