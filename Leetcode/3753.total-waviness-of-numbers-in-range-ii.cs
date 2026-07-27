/*
 * @lc app=leetcode id=3753 lang=csharp
 *
 * [3753] Total Waviness of Numbers in Range II
 */

// @lc code=start
public class Solution {
    public long TotalWaviness(long num1, long num2) {
        long[,,,,,] dp = new long[16, 2, 2, 10, 3, 16];

        void ResetDp()
        {
            for (int a = 0; a < 16; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            for (int e = 0; e < 3; e++)
                            {
                                for (int f = 0; f < 16; f++)
                                {
                                    dp[a, b, c, d, e, f] = -1L;
                                }
                            }
                        }
                    }
                }
            }
        }

        long Fun(int pos, int leadingZero, int tight, int prev, int state, int total, List<int> digits)
        {
            if (pos >= digits.Count)
            {
                return total;
            }

            if (dp[pos, leadingZero, tight, prev, state, total] >= 0)
            {
                return dp[pos, leadingZero, tight, prev, state, total];
            }

            long rst = 0L;
            int limit = tight == 1 ? digits[pos] : 9,
                newTight = 0;

            for (int i = 0; i <= limit; i++)
            {
                newTight = (tight == 1 && i == limit) ? 1 : 0;

                if (leadingZero == 1 && i == 0)
                {
                    rst += Fun(pos + 1, 1, newTight, prev, state, total, digits);
                }
                else if (leadingZero == 1)
                {
                    rst += Fun(pos + 1, 0, newTight, i, 0, 0, digits);
                }
                else if (i < prev && state == 2)
                {
                    rst += Fun(pos + 1, 0, newTight, i, 1, total + 1, digits);
                }
                else if (i < prev)
                {
                    rst += Fun(pos + 1, 0, newTight, i, 1, total, digits);
                }
                else if (i > prev && state == 1)
                {
                    rst += Fun(pos + 1, 0, newTight, i, 2, total + 1, digits);
                }
                else if (i > prev)
                {
                    rst += Fun(pos + 1, 0, newTight, i, 2, total, digits);
                }
                else
                {
                    rst += Fun(pos + 1, 0, newTight, i, 0, total, digits);
                }
            }

            return dp[pos, leadingZero, tight, prev, state, total] = rst;
        }

        num1--;
        int i = 15;
        List<int> digit1 = new (new int[16]);
        while (num1 > 0)
        {
            digit1[i] = (int)(num1 % 10);
            num1 /= 10;
            i--;
        }

        i = 15;
        List<int> digit2 = new (new int[16]);
        while (num2 > 0)
        {
            digit2[i] = (int)(num2 % 10);
            num2 /= 10;
            i--;
        }

        ResetDp();
        long t1 = Fun(0, 1, 1, 0, 0, 0, digit1);

        ResetDp();
        long t2 = Fun(0, 1, 1, 0, 0, 0, digit2);

        return t2 - t1;
    }
}
// @lc code=end

