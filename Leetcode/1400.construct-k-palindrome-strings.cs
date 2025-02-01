/*
 * @lc app=leetcode id=1400 lang=csharp
 *
 * [1400] Construct K Palindrome Strings
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string s, int k) {
        if (k > s.Length)
        {
            return false;
        }

        int[] cs = new int[26];
        foreach (char c in s)
        {
            cs[c - 'a']++;
        }

        int odd = 0;
        for (int i = 0; i < 26; i++)
        {
            if ((cs[i] & 1) > 0)
            {
                odd++;
            }
        }

        return odd <= k;
    }
}
// @lc code=end

