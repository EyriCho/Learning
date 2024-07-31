/*
 * @lc app=leetcode id=1653 lang=csharp
 *
 * [1653] Minimum Deletions to Make String Balanced
 */

// @lc code=start
public class Solution {
    public int MinimumDeletions(string s) {
        int b = 0,
            result = 0;
        foreach (char c in s)
        {
            if (c == 'b')
            {
                b++;
            }
            else
            {
                result = Math.Min(b, result + 1);
            }
        }
        return result;
    }
}
// @lc code=end

