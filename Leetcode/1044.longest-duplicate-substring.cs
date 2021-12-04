/*
 * @lc app=leetcode id=1044 lang=csharp
 *
 * [1044] Longest Duplicate Substring
 */

// @lc code=start
public class Solution {
    public string LongestDupSubstring(string s) {
        var result = string.Empty;
        var map = new int[s.Length];
        var power = new long[s.Length];
        long mod = 100_000_000_007;
        for (int i = 0; i < s.Length; i++)
        {
            map[i] = s[i] - 'a';
            power[i] = i == 0 ? 1 : (power[i - 1] * 26 % mod);
        }
        
        bool Valid(int len)
        {
            long temp = 0L;
            var set = new HashSet<long>();
            for (int i = 0; i < len; i++)
                temp = (temp * 26 + map[i]) % mod;
            set.Add(temp);
            
            for (int i = 1; i <= s.Length - len; i++)
            {
                temp = (temp * 26 - power[len] * map[i - 1] + map[i + len - 1]) % mod;
                if (temp < 0)
                    temp += mod;
                if (set.Contains(temp))
                {
                    if (len > result.Length)
                        result = s[i..(i + len)];
                    return true;
                }
                set.Add(temp);
            }
            
            return false;
        }
        
        int l = 1, r = s.Length;
        
        while (l < r)
        {
            var len = (l + r) >> 1;
            if (Valid(len))
                l = len + 1;
            else
                r = len;
        }
        
        return result;
    }
}
// @lc code=end

