/*
 * @lc app=leetcode id=935 lang=csharp
 *
 * [935] Knight Dialer
 */

// @lc code=start
public class Solution {
    public int KnightDialer(int n) {
        long[] a = new long[10] {
            1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L
        },
            b = new long[10],
            prev = b,
            curr = a;

        for (int i = 1; i < n; i++)
        {
            if ((i & 1) == 1)
            {
                prev = a;
                curr = b;
            }
            else
            {
                prev = b;
                curr = a;
            }

            curr[0] = (prev[4] + prev[6]) % 1_000_000_007;
            curr[1] = (prev[6] + prev[8]) % 1_000_000_007;
            curr[2] = (prev[7] + prev[9]) % 1_000_000_007;
            curr[3] = (prev[4] + prev[8]) % 1_000_000_007;
            curr[4] = (prev[0] + prev[3] + prev[9]) % 1_000_000_007;
            curr[5] = 0;
            curr[6] = (prev[0] + prev[1] + prev[7]) % 1_000_000_007;
            curr[7] = (prev[2] + prev[6]) % 1_000_000_007;
            curr[8] = (prev[1] + prev[3]) % 1_000_000_007;
            curr[9] = (prev[2] + prev[4]) % 1_000_000_007;
        }
        
        long result = 0L;
        for (int i = 0; i < 10; i++)
        {
            result = (result + curr[i]) % 1_000_000_007;
        }

        return (int)result;
    }
}
// @lc code=end

