/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i ||
                    strs[j][i] != strs[0][i])
                {
                    return strs[0][0..i];
                }
            }
        }

        return strs[0];
    }
}
// @lc code=end

