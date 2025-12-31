/*
 * @lc app=leetcode id=2147 lang=csharp
 *
 * [2147] Number of Ways to Divide a Long Corridor
 */

// @lc code=start
public class Solution {
    public int NumberOfWays(string corridor) {
        int s = 0, p = 0;
        long result = 1L;
        for (int i = 0; i < corridor.Length; i++)
        {
            if (corridor[i] == 'S')
            {
                if (s > 0 && (s & 1) == 0)
                {
                    result = (result * (p + 1)) % 1_000_000_007L;
                    p = 0;
                }
                s++;
                if (s == 2)
                {
                    p = 0;
                }
            }
            else if ((s & 1) == 0)
            {
                p++;
            }
        }

        if ((s & 1) == 1 || s == 0)
        {
            return 0;
        }
        return (int)result;
    }
}
// @lc code=end

