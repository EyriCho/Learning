/*
 * @lc app=leetcode id=127 lang=csharp
 *
 * [127] Word Ladder
 */

// @lc code=start
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var reached = new Dictionary<string, bool>();
        reached[beginWord] = true;
        var wordDict = new Dictionary<string, bool>();
        foreach (var word in wordList)
            wordDict[word] = true;
        if (!wordDict.ContainsKey(endWord))
            return 0;
        
        int length = 1;
        while (!reached.ContainsKey(endWord))
        {
            var toAdd = new Dictionary<string, bool>();
            foreach (var reach in reached.Keys)
            {
                for (int i = 0; i < reach.Length; i++)
                {
                    var array = reach.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        array[i] = c;
                        string str = new String(array);
                        if (wordDict.ContainsKey(str))
                        {
                            toAdd[str] = true;
                            wordDict.Remove(str);
                        }
                    }
                }
            }
            length++;
            if (toAdd.Count == 0)
                return 0;
            reached = toAdd;
        }
        
        return length;
    }
}
// @lc code=end

