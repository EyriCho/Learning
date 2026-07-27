/*
 * @lc app=leetcode id=3751 lang=csharp
 *
 * [3751] Total Waviness of Numbers in Range I
 */

// @lc code=start
public class Solution {
    public int TotalWaviness(int num1, int num2) {
        if (num2 < 101)
        {
            return 0;
        }

        int CountWave(int num)
        {
            int rst = 0,
                d = 0,
                prev2 = num % 10;
            num /= 10;
            int prev1 = num % 10;
            num /= 10;
            
            while (num > 0)
            {
                d = num % 10;
                if ((prev1 > d && prev1 > prev2) ||
                    (prev1 < d && prev1 < prev2))
                {
                    rst++;
                }

                prev2 = prev1;
                prev1 = d;
                num /= 10;
            }

            return rst;
        }

        int result = 0;
        for (int n = num1; n <= num2; n++)
        {
            result += CountWave(n);
        }
        return result;
    }
}
// @lc code=end

