/*
 * @lc app=leetcode id=438 lang=csharp
 *
 * [438] Find All Anagrams in a String
 */

// @lc code=start
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        if (s.Length < p.Length)
        {
            return result;
        }
        
        var dict = new Dictionary<char, int>();
        
        foreach (var c in p)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }
        
        int l = 0, r = 0, count = dict.Count;
        
        while (r < s.Length)
        {
            if (dict.ContainsKey(s[r]))
            {
                dict[s[r]]--;
                if (dict[s[r]] == 0)
                {
                    count--;
                }
            }
            
            r++;
            
            while (count == 0)
            {
                if (dict.ContainsKey(s[l]))
                {
                    dict[s[l]]++;
                    if (dict[s[l]] > 0)
                    {
                        count++;
                    }
                }
                
                if (r - l == p.Length)
                {
                    result.Add(l);
                }
                
                l++;
            }
        }
        
        return result;
    }
}
// @lc code=end

