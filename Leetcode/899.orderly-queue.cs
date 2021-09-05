/*
 * @lc app=leetcode id=899 lang=csharp
 *
 * [899] Orderly Queue
 */

// @lc code=start
public class Solution {
    public string OrderlyQueue(string s, int k) {
        if (s.Length == 1)
            return s;
        
        if (k > 1)
        {
            var array = s.ToCharArray();
            Array.Sort(array);
            return new string(array);
        }
        
        var minString = s;
        for (int i = 1; i < s.Length; i++)
        {
            var temp = s[i..] + s[0..i];
            if (temp.CompareTo(minString) < 0)
                minString = temp;        
        }
        
        return minString;
    }
}
// @lc code=end

