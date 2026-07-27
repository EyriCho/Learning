/*
 * @lc app=leetcode id=3867 lang=csharp
 *
 * [3867] Sum of GCD of Formed Pairs
 */

// @lc code=start
public class Solution {
    public long GcdSum(int[] nums) {
        int Gcd(int a, int b)
        {
            int temp = 0;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }

            return a;
        }

        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
            nums[i] = Gcd(max, nums[i]);
        }

        Array.Sort(nums);
        long result = 0;
        for (int l = 0, r = nums.Length - 1; l < r; l++, r--)
        {
            result += Gcd(nums[r], nums[l]);
        }
        return result;
    }
}
// @lc code=end

