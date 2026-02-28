/*
 * @lc app=leetcode id=1390 lang=csharp
 *
 * [1390] Four Divisors
 */

// @lc code=start
public class Solution {
    public int SumFourDivisors(int[] nums) {
        int result = 0,
            divisorSum = 0,
            divisorCount = 0;

        foreach (int num in nums)
        {
            divisorSum = 0;
            divisorCount = 0;

            for (int d = 1; d * d <= num; d++)
            {
                if (num % d != 0)
                {
                    continue;
                }

                if (num / d == d)
                {
                    divisorCount = 0;
                    break;
                }
                    
                divisorCount += 2;
                divisorSum += d + num / d;

                if (divisorCount > 4)
                {
                    break;
                }
            }

            if (divisorCount == 4)
            {
                result += divisorSum;
            }
        }

        return result;
    }
}
// @lc code=end

