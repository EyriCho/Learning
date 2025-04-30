/*
 * @lc app=leetcode id=368 lang=csharp
 *
 * [368] Largest Divisible Subset
 */

// @lc code=start
public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);

        (int len, int prev)[] dp = new (int, int)[nums.Length];
        dp[0] = (1, -1);

        int max = 1,
            last = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = (1, -1);
            for (int p = 0; p < i; p++)
            {
                if (nums[i] % nums[p] == 0 &&
                    dp[p].len + 1 > dp[i].len)
                {
                    dp[i] = (dp[p].len + 1, p);
                }
            }

            if (dp[i].len > max)
            {
                max = dp[i].len;
                last = i;
            }
        }

        List<int> result = new ();
        while (last > -1)
        {
            result.Add(nums[last]);
            last = dp[last].prev;
        }
        result.Reverse();

        return result;
    }
}
// @lc code=end

