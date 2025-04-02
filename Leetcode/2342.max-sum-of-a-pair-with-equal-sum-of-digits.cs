/*
 * @lc app=leetcode id=2342 lang=csharp
 *
 * [2342] Max Sum of a Pair With Equal Sum of Digits
 */

// @lc code=start
public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, int> dict = new ();
        int DigitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        int d = 0,
            result = -1;
        foreach (int num in nums)
        {
            d = DigitSum(num);
            if (dict.ContainsKey(d))
            {
                result = Math.Max(result, dict[d] + num);
                dict[d] = Math.Max(dict[d], num);
            }
            else
            {
                dict[d] = num;
            }
        }

        return result;
    }
}
// @lc code=end

