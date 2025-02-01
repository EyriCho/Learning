/*
 * @lc app=leetcode id=3223 lang=csharp
 *
 * [3223] Minimum Length of String After Operations
 */

// @lc code=start
public class Solution {
    public int MinimumLength(string s) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        int result = 0;
        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > 0)
            {
                result += counts[i] % 2 == 0 ? 2 : 1;
            }
        }

        return result;
    }
}
// @lc code=end

