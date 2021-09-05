/*
 * @lc app=leetcode id=926 lang=csharp
 *
 * [926] Flip String to Monotone Increasing
 */

// @lc code=start
public class Solution {
    public int MinFlipsMonoIncr(string s) {
        var dp0 = s[0] == '0' ? 0 : 1;
        var dp1 = 1 - dp0;
        
        for (int i = 1; i < s.Length; i++)
        {
            int _dp0 = 0, _dp1 = 0;
            if (s[i] == '0')
            {
                _dp0 = dp0;
                _dp1 = Math.Min(dp0, dp1) + 1;
            }
            else
            {
                _dp0 = dp0 + 1;
                _dp1 = Math.Min(dp0, dp1);
            }
            dp0 = _dp0;
            dp1 = _dp1;
        }
        
        return Math.Min(dp0, dp1);
    }
}
// @lc code=end

