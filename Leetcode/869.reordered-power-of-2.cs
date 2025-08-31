/*
 * @lc app=leetcode id=869 lang=csharp
 *
 * [869] Reordered Power of 2
 */

// @lc code=start
public class Solution {
    public bool ReorderedPowerOf2(int N) {
        int[] CountDigits(int num)
        {
            int[] rst = new int[10];
            while (num > 0)
            {
                rst[num % 10]++;
                num /= 10;
            }
            return rst;
        }

        int[] digits = CountDigits(n),
            digitPowerTwo = null;
        int powerTwo = 0,
            d = 0;
        for (int i = 0; i < 32; i++)
        {
            powerTwo = 1 << i;
            digitPowerTwo = CountDigits(powerTwo);

            d = 0;
            while (d < 10)
            {
                if (digits[d] != digitPowerTwo[d])
                {
                    break;
                }
                d++;
            }

            if (d == 10)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

