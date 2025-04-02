/*
 * @lc app=leetcode id=2523 lang=csharp
 *
 * [2523] Closest Prime Numbers in Range
 */

// @lc code=start
public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        bool[] sieve = new bool[right + 1];
        sieve[0] = sieve[1] = true;

        for (int i = 2; i * i <= right; i++)
        {
            if (sieve[i])
            {
                continue;
            }

            for (int j = i * i; j <= right; j += i)
            {
                sieve[j] = true; 
            }
        }

        int[] result = new int[] { -1, -1 };
        int last = -1,
            min = right;
        for (int i = left; i <= right; i++)
        {
            if (sieve[i])
            {
                continue;
            }

            if (last >= 0)
            {
                if (i - last < min)
                {
                    min = i - last;
                    result[0] = last;
                    result[1] = i;
                }
            }

            last = i;
        }

        return result;
    }
}
// @lc code=end

