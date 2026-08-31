/*
 * @lc app=leetcode id=3090 lang=csharp
 *
 * [3090] Maximum Length Substring With Two Occurrences
 */

// @lc code=start
public class Solution {
    public int MaximumLengthSubstring(string s) {
        int result = 2,
            idx = 0,
            l = 0;
        
        int[] counts = new int[26];
        for (int r = 0; r < s.Length; r++)
        {
            idx = s[r] - 'a';
            if (counts[idx] == 2)
            {
                while (s[l] != s[r])
                {
                    counts[s[l] - 'a']--;
                    l++;
                }
                l++;
            }
            else
            {
                counts[idx]++;
            }

            result = Math.Max(result, r - l + 1);
        }
        
        return result;
    }
}
// @lc code=end

