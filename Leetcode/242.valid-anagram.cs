/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        var sCounts = new int[26];
        foreach (var c in s)
        {
            sCounts[c - 'a']++;
        }
        
        var tCounts = new int[26];
        foreach (var c in t)
        {
            tCounts[c - 'a']++;
        }
        
        for (int i = 0; i < 26; i++)
        {
            if (sCounts[i] != tCounts[i])
            {
                return false;
            }
        }
        
        return true;
    }
}
// @lc code=end

