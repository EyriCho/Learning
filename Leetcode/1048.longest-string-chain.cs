/*
 * @lc app=leetcode id=1048 lang=csharp
 *
 * [1048] Longest String Chain
 */

// @lc code=start
public class Solution {
    public int LongestStrChain(string[] words) {
        var wordDict = new Dictionary<string, int>[17];
        for (int i = 1; i < 17; i++)
            wordDict[i] = new Dictionary<string, int>();
        
        foreach (var word in words)
            if (!wordDict[word.Length].ContainsKey(word))
                wordDict[word.Length].Add(word, 1);
        
        var result = 1;
        for (int i = 16; i > 1; i--)
        {
            var shortDict = wordDict[i - 1];
            foreach (var set in wordDict[i])
            {
                for (int j = 0; j < set.Key.Length; j++)
                {
                    var s = $"{set.Key[0..j]}{set.Key[(j + 1)..set.Key.Length]}";
                    if (shortDict.ContainsKey(s))
                    {
                        shortDict[s] = Math.Max(shortDict[s], set.Value + 1);
                        result = Math.Max(result, shortDict[s]);
                    }
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

