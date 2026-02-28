/*
 * @lc app=leetcode id=3666 lang=csharp
 *
 * [3666] Minimum Operations to Equalize Binary String
 */

// @lc code=start
public class Solution {
    public int MinOperations(string s, int k) {
        int zero = 0,
            one = 0;
        foreach (char c in s)
        {
            zero += c == '0' ? 1 : 0;
        }

        if (zero == 0)
        {
            return 0;
        }
        else if (zero == k)
        {
            return 1;
        }
        else if (k == 1)
        {
            return zero;
        }

        if (s.Length == k)
        {
            return zero switch
            {
                0 => 0,
                _ when zero == s.Length => 1,
                _ => -1,
            };
        }

        one = s.Length - zero;
        long totalFlip = 0L;
        for (int ops = 1; ops <= s.Length; ops++)
        {
            totalFlip = ops * 1L * k;

            if ((totalFlip - zero) % 2 != 0)
            {
                continue;
            }

            if (ops % 2 == 1)
            {
                if (totalFlip >= zero &&
                    totalFlip <= zero * ops + one * (ops - 1))
                {
                    return ops;
                }
            }
            else 
            {
                if (totalFlip >= zero &&
                    totalFlip <= zero * (ops - 1) + one * ops)
                {
                    return ops;
                }
            }
        }

        return -1;
    }
}
// @lc code=end

