/*
 * @lc app=leetcode id=762 lang=csharp
 *
 * [762] Prime Number of Set Bits in Binary Representation
 */

// @lc code=start
public class Solution {
    public int CountPrimeSetBits(int left, int right) {
        int[] primes = new int[] {
            2, 3, 5, 7,
            11, 13, 17, 19,
            23, 29,
            31,
        };

        int result = 0,
            bits = 0,
            num = 0;
        for (int i = left; i <= right; i++)
        {
            num = i;
            bits = 0;
            while (num > 0)
            {
                bits++;
                num &= num - 1;
            }

            if (primes.Contains(bits))
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

