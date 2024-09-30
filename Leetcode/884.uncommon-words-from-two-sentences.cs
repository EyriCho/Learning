/*
 * @lc app=leetcode id=884 lang=csharp
 *
 * [884] Uncommon Words from Two Sentences
 */

// @lc code=start
public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string[] words1 = s1.Split(' '),
            words2 = s2.Split(' ');

        int count = 0;
        Dictionary<string, int> dict1 = new (),
            dict2 = new ();
        foreach (string word in words1)
        {
            dict1.TryGetValue(word, out count);
            dict1[word] = count + 1;
        }

        foreach (string word in words2)
        {
            dict2.TryGetValue(word, out count);
            dict2[word] = count + 1;
        }

        List<string> list = new ();
        foreach (KeyValuePair<string, int> kv in dict1)
        {
            if (kv.Value == 1 && !dict2.ContainsKey(kv.Key))
            {
                list.Add(kv.Key);
            }
        }
        foreach (KeyValuePair<string, int> kv in dict2)
        {
            if (kv.Value == 1 && !dict1.ContainsKey(kv.Key))
            {
                list.Add(kv.Key);
            }
        }

        return list.ToArray();
    }
}
// @lc code=end

