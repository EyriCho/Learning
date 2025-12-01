/*
 * @lc app=leetcode id=1262 lang=csharp
 *
 * [1262] Greatest Sum Divisible by Three
 */

// @lc code=start
public class Solution {
    public int MaxSumDivThree(int[] nums) {
        int sum = 0,
            min10 = int.MaxValue, min11 = int.MaxValue,
            min20 = int.MaxValue, min21 = int.MaxValue;
        
        foreach (int num in nums)
        {
            sum += num;
            if (num % 3 == 1)
            {
                if (num < min10)
                {
                    min11 = min10;
                    min10 = num;
                }
                else if (num < min11)
                {
                    min11 = num;
                }
            }
            else if (num % 3 == 2)
            {
                if (num < min20)
                {
                    min21 = min20;
                    min20 = num;
                }
                else if (num < min21)
                {
                    min21 = num;
                }
            }
        }

        if (sum % 3 == 0)
        {
            return sum;
        }
        int result = 0;
        if (sum % 3 == 1)
        {
            if (min10 < int.MaxValue)
            {
                result = Math.Max(result, sum - min10);
            }
            if (min21 < int.MaxValue)
            {
                result = Math.Max(result, sum - min20 - min21);
            }
        }
        else
        {
            if (min20 < int.MaxValue)
            {
                result = Math.Max(result, sum - min20);
            }
            if (min11 < int.MaxValue)
            {
                result = Math.Max(result, sum - min10 - min11);
            }
        }

        return result;
    }
}
// @lc code=end

