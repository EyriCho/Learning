/*
 * @lc app=leetcode id=1208 lang=csharp
 *
 * [1208] Get Equal Substrings Within Budget
 */

// @lc code=start
public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int cost = 0,
            result = 0,
            l = 0,
            r = 0;

        while (r < s.Length)
        {
            cost += Math.Abs(s[r] - t[r]);

            while (cost > maxCost)
            {
                cost -= Math.Abs(s[l] - t[l]);
                l++;
            }

            result = Math.Max(result, r - l + 1);
            r++;
        }

        return result;
    }
}
// @lc code=end

