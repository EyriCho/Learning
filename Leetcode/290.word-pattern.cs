/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */

// @lc code=start
public class Solution {
    public bool WordPattern(string pattern, string str) {
        Dictionary<object, int> dic = new Dictionary<object, int>();
        var charaters = pattern.ToCharArray();
        var words = str.Split(" ");

        if (charaters.Length != words.Length) return false;
        
        for (int i = 0; i < charaters.Length; i++)
        {
            char c = charaters[i];
            string w = words[i];

            if (!dic.ContainsKey(c)) dic[c] = i;
            if (!dic.ContainsKey(w)) dic[w] = i;

            if (dic[c] != dic[w]) return false;
        }
        return true;        
    }
}
// @lc code=end

