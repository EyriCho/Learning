/*
 * @lc app=leetcode id=1799 lang=csharp
 *
 * [1799] Maximize Score After N Operations
 */

// @lc code=start
public class Solution {
    public int MaxScore(int[] nums) {
        var gcd = new int[nums.Length, nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int num1 = 0, num2 = 0;
                if (nums[i] > nums[j])
                {
                    num1 = nums[i];
                    num2 = nums[j];
                }
                else
                {
                    num1 = nums[j];
                    num2 = nums[i];
                }

                while (num2 > 0)
                {
                    var left = num1 % num2;
                    num1 = num2;
                    num2 = left;
                }

                gcd[i, j] = num1;
            }
        }

        int CountBits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num &= (num - 1);
                count++;
            }
            return count;
        }

        var total = 1 << nums.Length;
        var dp = new int[total];
        for (int i = 0; i < total; i++)
        {
            var count = CountBits(i);
            if ((count & 1) == 1)
            {
                continue;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int state = (1 << j) | (1 << k);

                    if ((i & state) != state)
                    {
                        continue;
                    }

                    dp[i] = Math.Max(dp[i], dp[i - state] + gcd[j, k] * (count >> 1));
                }
            }
        }

        return dp[total - 1];
    }
}
// @lc code=end

