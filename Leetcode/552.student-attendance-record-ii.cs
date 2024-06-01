/*
 * @lc app=leetcode id=552 lang=csharp
 *
 * [552] Student Attendance Record II
 */

// @lc code=start
public class Solution {
    public int CheckRecord(int n) {
        long dp0 = 1L,
            dp1 = 0L,
            dp2 = 0L,
            dp3 = 0L,
            dp4 = 0L,
            dp5 = 0L,
            n0 = 0L,
            n3 = 0L;
        const int mod = 1_000_000_007;
        
        for (int i = 1; i <= n; i++)
        {
            n0 = (dp0 + dp1 + dp2) % mod;
            n3 = (dp0 + dp1 + dp2 + dp3 + dp4 + dp5) % mod;
            dp2 = dp1;
            dp1 = dp0;
            dp5 = dp4;
            dp4 = dp3;
            dp0 = n0;
            dp3 = n3;
        }

        return (int)((dp0 + dp1 + dp2 + dp3 + dp4 + dp5) % mod);
    }
}
// @lc code=end

