/*
 * @lc app=leetcode id=140 lang=csharp
 *
 * [140] Word Break II
 */

// @lc code=start
public class Solution {
    string _s;
    IList<string> _wordDict;
    Dictionary<string, List<string>> temp;
    IList<string> result;
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        _s = s;
        _wordDict = wordDict;
        temp = new Dictionary<string, List<string>>();
        return dfs(0);
    }
    
    private List<string> dfs(int startPos)
    {
        if (temp.ContainsKey(_s[startPos..]))
            return temp[_s[startPos..]];
        if (startPos == _s.Length) return new List<string> { string.Empty };
        
        var list = new List<string>();
        foreach (var word in _wordDict)
        {
            if (startPos + word.Length > _s.Length || _s[startPos..(startPos + word.Length)] != word) continue;
            var sub = dfs(startPos + word.Length);
            foreach (var str in sub)
            {
                list.Add(word + (str == string.Empty ? "" : (" " + str)));
            }
        }
        temp[_s[startPos..]] = list;
        return list;
    }
}
// @lc code=end

