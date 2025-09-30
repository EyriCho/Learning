/*
 * @lc app=leetcode id=966 lang=csharp
 *
 * [966] Vowel Spellchecker
 */

// @lc code=start
public class Solution {
    public string[] Spellchecker(string[] wordlist, string[] queries) {
        HashSet<string> set = new (wordlist);
        Dictionary<string, string> lowerDict = new();
        Dictionary<string, string> vowelDict = new ();
        HashSet<char> vowels = new () {
            'a', 'e', 'i', 'o', 'u',
        };

        string ExcludeVowel(string str)
        {
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    array[i] = '*';
                }
            }
            return new string(array);
        }

        string lower = string.Empty,
            vowel = string.Empty;
        foreach (string word in wordlist)
        {
            lower = word.ToLower();
            vowel = ExcludeVowel(lower);
            if (!lowerDict.ContainsKey(lower))
            {
                lowerDict.Add(lower, word);
            }
            if (!vowelDict.ContainsKey(vowel))
            {
                vowelDict.Add(vowel, word);
            }
        }

        string[] result = new string[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            if (set.Contains(queries[i]))
            {
                result[i] = queries[i];
                continue;
            }

            lower = queries[i].ToLower();
            if (lowerDict.ContainsKey(lower))
            {
                result[i] = lowerDict[lower];
                continue;
            }

            vowel = ExcludeVowel(lower);
            if (vowelDict.ContainsKey(vowel))
            {
                result[i] = vowelDict[vowel];
                continue;
            }

            result[i] = string.Empty;
        }

        return result;
    }
}
// @lc code=end

