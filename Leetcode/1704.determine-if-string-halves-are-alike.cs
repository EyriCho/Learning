/*
 * @lc app=leetcode id=1704 lang=csharp
 *
 * [1704] Determine if String Halves Are Alike
 */

// @lc code=start
public class Solution {
    public bool HalvesAreAlike(string s) {
        int lCount = 0, rCount = 0;
        
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U' };
        
        for (int l = 0, r = s.Length - 1; l < r; l++, r--)
        {
            if (vowels.Contains(s[l]))
            {
                lCount++;
            }
            if (vowels.Contains(s[r]))
            {
                rCount++;
            }
        }
        
        return lCount == rCount;    
    }
}
// @lc code=end

