/*
 * @lc app=leetcode id=792 lang=csharp
 *
 * [792] Number of Matching Subsequences
 */

// @lc code=start
public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        var result = 0;
        var dict = new Dictionary<string, bool>();
        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
            {
                if (dict[word])
                    result++;
                continue;
            }
            
            
            int i = 0, w = 0;
            while (i < s.Length && w < word.Length)
            {
                if (s[i] == word[w])
                    w++;
                i++;
            }
            if (w == word.Length)
                result++;
            dict[word] = w == word.Length;
        }
        return result;
    }
}
// @lc code=end

