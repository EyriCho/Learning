/*
 * @lc app=leetcode id=2654 lang=csharp
 *
 * [2654] Minimum Number of Operations to Make All Array Elements Equal to 1
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        int ones = 0;
        foreach (int num in nums)
        {
            ones += num == 1 ? 1 : 0;
        }
        if (ones > 0)
        {
            return nums.Length - ones;
        }

        int Gcd(int num1, int num2)
        {
            int temp = 0;
            while (num2 != 0)
            {
                temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return temp;
        }

        int gcd = 0,
            result = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            gcd = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                gcd = Gcd(gcd, nums[j]);
                if (gcd == 1)
                {
                    result = Math.Min(result, j - i + nums.Length - 1);
                    break;
                }
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

