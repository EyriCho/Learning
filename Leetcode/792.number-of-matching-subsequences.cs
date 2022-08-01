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
            int i = 0, j = 0;
            if (dict.ContainsKey(word))
            {
                j = dict[word] ? word.Length : 0;
            }
            else
            {
                while (i < s.Length && j < word.Length)
                {
                    if (s[i] == word[j])
                    {
                        j++;
                    }
                    i++;
                }
                dict[word] = j == word.Length;
            }
            result += (dict[word] ? 1 : 0);
        }
        
        return result;
    }
}
// @lc code=end

