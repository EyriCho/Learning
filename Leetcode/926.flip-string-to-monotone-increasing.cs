/*
 * @lc app=leetcode id=926 lang=csharp
 *
 * [926] Flip String to Monotone Increasing
 */

// @lc code=start
public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int result = 0,
            one = 0;

        foreach (var c in s)
        {
            if (c == '1')
            {
                one++;
            }
            else
            {
                result = Math.Min(result + 1, one);
            }
        }

        return result;
    }
}
// @lc code=end

