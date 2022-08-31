/*
 * @lc app=leetcode id=30 lang=csharp
 *
 * [30] Substring with Concatenation of All Words
 */

// @lc code=start
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if (s.Length == 0 || words.Length == 0)
        {
            return result;
        }
        
        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict[word] = 1;
            }
        }
        
        for (int i = 0; i < words[0].Length; i++)
        {
            var currDict = new Dictionary<string, int>();
            int count = 0, left = i;
            
            for (int j = i; j <= s.Length - words[0].Length; j += words[0].Length)
            {
                var w = s[j..(j + words[0].Length)];
                if (dict.ContainsKey(w))
                {
                    if (currDict.ContainsKey(w))
                    {
                        currDict[w]++;
                    }
                    else
                    {
                        currDict[w] = 1;
                    }
                    
                    if (currDict[w] <= dict[w])
                    {
                        count++;
                    }
                    else
                    {
                        while (currDict[w] > dict[w])
                        {
                            var prev = s[left..(left + words[0].Length)];
                            currDict[prev]--;
                            if (currDict[prev] < dict[prev])
                            {
                                count--;
                            }
                            left += words[0].Length;
                        }
                    }
                    
                    if (count == words.Length)
                    {
                        result.Add(left);
                        currDict[s[left..(left + words[0].Length)]]--;
                        count--;
                        left += words[0].Length;
                    }
                }
                else
                {
                    currDict.Clear();
                    count = 0;
                    left = j + words[0].Length;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

