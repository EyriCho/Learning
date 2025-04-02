/*
 * @lc app=leetcode id=2364 lang=csharp
 *
 * [2364] Count Number of Bad Pairs
 */

// @lc code=start
public class Solution {
    public long CountBadPairs(int[] nums) {
        Dictionary<long, long> dict = new ();
        long count = 0L,
            diff = 0L,
            result = (long)nums.Length * (nums.Length - 1) >> 1;

        for (int i = 0; i < nums.Length; i++)
        {
            diff = nums[i] - i;
            dict.TryGetValue(diff, out count);

            result -= count;
            dict[diff] = count + 1;
        }

        return result;
    }
}
// @lc code=end

