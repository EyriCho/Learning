/*
 * @lc app=leetcode id=890 lang=csharp
 *
 * [890] Find and Replace Pattern
 */

// @lc code=start
public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var result = new List<string>();
        
        foreach (var word in words)
        {
            var match = new char[26];
            var revMatch = new char[26];
            
            int i = 0;
            for (;i < word.Length; i++)
            {
                var pos = word[i] - 'a';
                if (match[pos] == '\0')
                    match[pos] = pattern[i];
                else if (match[pos] != pattern[i])
                    break;
                
                pos = pattern[i] - 'a';
                if (revMatch[pos] == '\0')
                    revMatch[pos] = word[i];
                else if (revMatch[pos] != word[i])
                    break;
            }
            
            if (i == word.Length)
                result.Add(word);
        }
        
        return result;
    }
}
// @lc code=end

