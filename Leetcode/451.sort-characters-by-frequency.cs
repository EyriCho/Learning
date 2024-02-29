/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

// @lc code=start
public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> dict = new ();
        foreach (char c in s)
        {
            dict.TryGetValue(c, out int count);
            dict[c] = count + 1;
        }
        
        char[] chars = new char[s.Length];
        int i = 0;
        foreach (KeyValuePair<char, int> kv in dict.OrderByDescending(kv => kv.Value))
        {
            Array.Fill(chars, kv.Key, i, kv.Value);
            i += kv.Value;
        }
        
        return new string(chars);
    }
}
// @lc code=end

