/*
 * @lc app=leetcode id=2486 lang=csharp
 *
 * [2486] Append Characters to String to Make Subsequence
 */

// @lc code=start
public class Solution {
    public int AppendCharacters(string s, string t) {
        int s1 = 0,
            t1 = 0;
        
        while (s1 < s.Length && t1 < t.Length)
        {
            if (s[s1] == t[t1])
            {
                t1++;
            }
            s1++;
        }

        return t.Length - t1;
    }
}
// @lc code=end

