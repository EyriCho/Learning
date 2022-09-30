/*
 * @lc app=leetcode id=336 lang=csharp
 *
 * [336] Palindrome Pairs
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words) {
        var result = new List<IList<int>>();
        
        bool IsPalindrome(string w)
        {
            int l = 0,
                r = w.Length - 1;
            
            while (l < r)
            {
                if (w[l++] != w[r--])
                {
                    return false;
                }
            }
            
            return true;
        }
        
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            dict.Add(words[i], i);
        }
        
        for (int i = 0; i < words.Length; i++)
        {
            var reverse = new char[words[i].Length];
            for (int j = words[i].Length - 1; j >= 0; j--)
            {
                reverse[words[i].Length - 1 - j] = words[i][j];
            }
            string s = new string(reverse);
            
            if (dict.ContainsKey(s) && dict[s] != i)
            {
                result.Add(new List<int>() { i, dict[s] });
            }
            
            for (int j = 1; j <= words[i].Length; j++)
            {
                s = new string(reverse[0..(words[i].Length - j)]);
                if (IsPalindrome(words[i][0..j]) && dict.ContainsKey(s))
                {
                    result.Add(new List<int>() { dict[s], i });
                }
                
                s = new string(reverse[j..]);
                if (IsPalindrome(words[i][(words[i].Length - j)..]) && dict.ContainsKey(s))
                {
                    result.Add(new List<int>() { i, dict[s] });
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

