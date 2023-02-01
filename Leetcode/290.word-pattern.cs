/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */

// @lc code=start
public class Solution {
    public bool WordPattern(string pattern, string str) {
        var wordDic = new Dictionary<string, int>();
        var charDic = new Dictionary<char, int>();

        var words = s.Split(' ');
        if (words.Length != pattern.Length)
        {
            return false;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!wordDic.TryGetValue(words[i], out int w))
            {
                wordDic[words[i]] = w = i;
            }

            if (!charDic.TryGetValue(pattern[i], out int c))
            {
                charDic[pattern[i]] = c = i;
            }

            if (w != c)
            {
                Console.WriteLine($"{w} {c}");
                Console.WriteLine(i);
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

