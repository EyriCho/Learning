/*
 * @lc app=leetcode id=187 lang=csharp
 *
 * [187] Repeated DNA Sequences
 */

// @lc code=start
public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var result = new List<string>();
        if (s.Length < 11)
            return result;
        
        var dict = new Dictionary<int, int>();
        int tmp = 0;
        for (int i = 0; i < 9; i++)
            tmp = (tmp << 3) | (s[i] & 7);
        
        for (int i = 9; i < s.Length; i++)
        {
            tmp = ((tmp << 3) & 0x3fffffff) | (s[i] & 7);
            if (dict.ContainsKey(tmp))
            {
                if (dict[tmp] == 1)
                {
                    result.Add(s[(i - 9)..(i + 1)]);
                    dict[tmp] = 2;
                }
            }
            else
                dict[tmp] = 1;
        }
        
        return result;
    }
}
// @lc code=end

