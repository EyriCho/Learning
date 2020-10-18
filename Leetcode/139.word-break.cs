/*
 * @lc app=leetcode id=139 lang=csharp
 *
 * [139] Word Break
 */

// @lc code=start
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var temp = new bool[s.Length + 1];
        temp[0] = true;
        
        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (temp[j] && wordDict.Contains(s[j..i]))
                {
                    temp[i] = true;
                    break;
                }
            }
        }
        
        return temp[s.Length];
    }
}
// @lc code=end

