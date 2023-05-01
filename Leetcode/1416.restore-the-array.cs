/*
 * @lc app=leetcode id=1416 lang=csharp
 *
 * [1416] Restore The Array
 */

// @lc code=start
public class Solution {
    public int NumberOfArrays(string s, int k) {
        var dp = new int[s.Length + 1];
        dp[s.Length] = 1;

        for (int i = s.Length - 1; i > -1; i--)
        {
            if (s[i] == '0')
            {
                continue;
            }

            int j = i;
            var num = 0L;
            while (j < s.Length)
            {
                num = num * 10 + s[j] - '0';
                if (num > k)
                {
                    break;
                }

                dp[i] = (dp[i] + dp[j + 1]) % 1_000_000_007;
                j++;
            }
        }

        return dp[0];
    }
}
// @lc code=end

