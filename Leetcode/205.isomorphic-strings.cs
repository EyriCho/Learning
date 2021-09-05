/*
 * @lc app=leetcode id=205 lang=csharp
 *
 * [205] Isomorphic Strings
 */

// @lc code=start
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> sDict = new Dictionary<char, char>(),
            tDict = new Dictionary<char, char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (!sDict.ContainsKey(s[i]))
                sDict[s[i]] = t[i];
            else if (sDict[s[i]] != t[i])
                return false;
            
            if (!tDict.ContainsKey(t[i]))
                tDict[t[i]] = s[i];
            else if (tDict[t[i]] != s[i])
                return false;
        }
        
        return true;
    }
}
// @lc code=end

