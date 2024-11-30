/*
 * @lc app=leetcode id=3133 lang=csharp
 *
 * [3133] Minimum Array End
 */

// @lc code=start
public class Solution {
    public long MinEnd(int n, int x) {
        if (n == 1)
        {
            return x;
        }

        n--;

        long result = (long)x,
            masking = 1L;
        while (n > 0)
        {            
            if ((result & masking) == 0L)
            {
                if ((n & 1) > 0)
                {
                    result |= masking;
                }
                n >>= 1;
            }

            masking <<= 1;
        }

        return result;
    }
}
// @lc code=end

