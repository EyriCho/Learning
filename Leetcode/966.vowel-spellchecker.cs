/*
 * @lc app=leetcode id=966 lang=csharp
 *
 * [966] Vowel Spellchecker
 */

// @lc code=start
public class Solution {
    public string[] Spellchecker(string[] wordlist, string[] queries) {
        var vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
        string GetVowel(string s)
        {
            var chars = new char[s.Length];
            for (int j = 0; j < s.Length; j++)
            {
                var c = Char.ToLower(s[j]);
                chars[j] = vowel.Contains(c) ? '-' : c;
            }
            
            return new string(chars);
        }
        
        var result = new string[queries.Length];
        
        var word_Set = new HashSet<string>(wordlist);
        var word_Cap = new Dictionary<string, string>();
        var word_Vow = new Dictionary<string, string>();
        
        foreach (var word in wordlist)
        {
            var l = word.ToLower();
            if (!word_Cap.ContainsKey(l))
                word_Cap.Add(l, word);
            var v = GetVowel(word);
            if (!word_Vow.ContainsKey(v))
                word_Vow.Add(v, word);
        }
        
        for (int i = 0; i < queries.Length; i++)
        {
            if (word_Set.Contains(queries[i]))
            {
                result[i] = queries[i];
                continue;
            }
            var l = queries[i].ToLower();
            if (word_Cap.ContainsKey(l))
            {
                result[i] = word_Cap[l];
                continue;
            }
            var v = GetVowel(queries[i]);
            if (word_Vow.ContainsKey(v))
            {
                result[i] = word_Vow[v];
                continue;
            }
            result[i] = string.Empty;
        }
        
        return result;
    }
}
// @lc code=end

