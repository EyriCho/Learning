/*
 * @lc app=leetcode id=1750 lang=csharp
 *
 * [1750] Minimum Length of String After Deleting Similar Ends
 */

// @lc code=start
public class Solution {
    public int MinimumLength(string s) {
        int l = 0,
            r = s.Length - 1,
            i = 0;
        
        while (l < r && s[l] == s[r])
        {
            i = l;
            while (l <= r && s[i] == s[l])
            {
                l++;
            }

            while (l <= r && s[i] == s[r])
            {
                r--;
            }
        }

        return l <= r ? (r - l + 1) : 0;
    }
}
// @lc code=end

