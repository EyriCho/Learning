/*
 * @lc app=leetcode id=3578 lang=csharp
 *
 * [3578] Count Partitions With Max-Min Difference at Most K
 */

// @lc code=start
public class Solution {
    public int CountPartitions(int[] nums, int k) {
        const long mod = 1_000_000_007L;
        long[] dp = new long[nums.Length + 1];
        dp[0] = 1L;

        LinkedList<int> minLink = new (),
            maxLink = new ();
        long sum = 0L;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            while (minLink.Count > 0 &&
                nums[r] <= nums[minLink.Last.Value])
            {
                minLink.RemoveLast();
            }
            while (maxLink.Count > 0 &&
                nums[r] >= nums[maxLink.Last.Value])
            {
                maxLink.RemoveLast();
            }
            
            minLink.AddLast(r);
            maxLink.AddLast(r);

            while (nums[maxLink.First.Value] - nums[minLink.First.Value] > k)
            {
                if (minLink.First.Value == l)
                {
                    minLink.RemoveFirst();
                }
                if (maxLink.First.Value == l)
                {
                    maxLink.RemoveFirst();
                }
                sum = (sum - dp[l] + mod) % mod;
                l++;
            }

            sum = (sum + dp[r]) % mod;
            dp[r + 1] = sum;
        }

        return (int)dp[nums.Length];
    }
}
// @lc code=end

