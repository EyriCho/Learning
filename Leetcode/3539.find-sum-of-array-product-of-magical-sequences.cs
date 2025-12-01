/*
 * @lc app=leetcode id=3539 lang=csharp
 *
 * [3539] Find Sum of Array Product of Magical Sequences
 */

// @lc code=start
public class Solution {
    public int MagicalSum(int m, int k, int[] nums) {
        const long mod = 1_000_000_007L;
        long[,] powers = new long[nums.Length, m + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            powers[i, 0] = 1L;
            for (int j = 1; j <= m; j++)
            {
                powers[i, j] = powers[i, j - 1] * nums[i] % mod;
            }
        }

        long[,] combines = new long[m + 1, m + 1];
        for (int i = 0; i <= m; i++)
        {
            combines[i, 0] = 1L;
            for (int j = 1; j <= i; j++)
            {
                combines[i, j] = (combines[i - 1, j - 1] + combines[i - 1, j]) % mod;
            }
        }

        long[,,] dp = new long[m + 1, m + 1, k + 1],
            next = null;
        dp[m, 0, 0] = 1L;

        int total = 0,
            newLeft = 0,
            newOne = 0,
            newCarry = 0;
        long add = 0L;
        for (int i = 0; i < nums.Length; i++)
        {
            next = new long[m + 1, m + 1, k + 1];
            for (int left = 0; left <= m; left++)
            {
                for (int carry = 0; carry <= m; carry++)
                {
                    for (int ones = 0; ones <= k; ones++)
                    {
                        if (dp[left, carry, ones] == 0L)
                        {
                            continue;
                        }
                        for (int select = 0; select <= left; select++)
                        {
                            total = select + carry;
                            newLeft = left - select;
                            newOne = ones + (total & 1);
                            if (newOne > k)
                            {
                                continue;
                            }
                            newCarry = total >> 1;

                            add = (dp[left, carry, ones] * powers[i, select]) % mod;
                            add = (add * combines[left, select]) % mod;

                            next[newLeft, newCarry, newOne] = (next[newLeft, newCarry, newOne] + add) % mod;
                        }
                    }
                }
            }
            dp = next;
        }

        long result = 0;
        int needOnes = 0;
        for (int carry = 0; carry <= m; carry++)
        {
            needOnes = k - BitOperations.PopCount((uint)carry);
            if (needOnes >= 0)
            {
                result = (result + dp[0, carry, needOnes]) % mod;
            }
        }
        return (int)result;
    }
}
// @lc code=end

