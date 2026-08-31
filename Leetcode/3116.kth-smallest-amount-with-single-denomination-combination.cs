/*
 * @lc app=leetcode id=3116 lang=csharp
 *
 * [3116] Kth Smallest Amount With Single Denomination Combination
 */

// @lc code=start
public class Solution {
    public long FindKthSmallest(int[] coins, int k) {
        Array.Sort(coins);
        List<int> usefulCoins = new ();
        bool redundant = false;
        foreach (int coin in coins)
        {
            redundant = false;
            foreach (int prevCoin in usefulCoins)
            {
                if (coin % prevCoin == 0)
                {
                    redundant = true;
                    break;
                }
            }

            if (!redundant)
            {
                usefulCoins.Add(coin);

            }
        }

        long Gcd(long a, long b)
        {
            long temp = 0L;
            while (b > 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        int LocateLastBit(int mask)
        {
            int rst = 0;
            while ((mask & (1 << rst)) == 0)
            {
                rst++;
            }
            return rst;
        }

        int total = 1 << usefulCoins.Count,
            prevMask = 0,
            lastBit = 0;
        long currentLCM = 1L,
            gcd = 0L,
            sign = 1L,
            l = usefulCoins[0],
            m = 0L,
            r = 1L * k * usefulCoins[0],
            count = 0L;
        long[] lcms = new long[total];
        lcms[0] = 1L;
        int[] counts = new int[total];

        for (int mask = 1; mask < total; mask++)
        {
            prevMask = mask & (mask - 1);
            lastBit = LocateLastBit(mask);

            gcd = Gcd(lcms[prevMask], usefulCoins[lastBit]);
            currentLCM = lcms[prevMask] / gcd;
            if (currentLCM > r / usefulCoins[lastBit])
            {
                currentLCM = r + 1L;
            }
            else
            {
                currentLCM *= usefulCoins[lastBit];
            }

            lcms[mask] = currentLCM;
            counts[mask] = counts[prevMask] + 1;
        }

        while (l < r)
        {
            m = l + (r - l) / 2L;
            count = 0L;

            for (int mask = 1; mask < total; mask++)
            {
                if (lcms[mask] <= m)
                {
                    sign = counts[mask] % 2 == 1 ? 1L : -1L;
                    count += sign * (m / lcms[mask]);
                }
            }

            if (count >= k)
            {
                r = m;
            }
            else
            {
                l = m + 1L;
            }
        }

        return l;
    }
}
// @lc code=end

