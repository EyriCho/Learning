/*
 * @lc app=leetcode id=1358 lang=csharp
 *
 * [1358] Number of Substrings Containing All Three Characters
 */

// @lc code=start
public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] counts = new int[3];
        int result = 0;

        for (int l = 0, r = 0; r < s.Length; r++)
        {
            counts[s[r] - 'a']++;
            while (counts[0] > 0 &&
                counts[1] > 0 &&
                counts[2] > 0)
            {
                counts[s[l] - 'a']--;
                l++;
            }

            result += l;
        }

        return result;
    }
}
// @lc code=end

