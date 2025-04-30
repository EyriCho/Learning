/*
 * @lc app=leetcode id=2537 lang=csharp
 *
 * [2537] Count the Number of Good Subarrays
 */

// @lc code=start
public class Solution {
    public long CountGood(int[] nums, int k) {
        Dictionary<int, int> dict = new ();
        int l = 0,
            r = 0,
            count = 0,
            pairs = 0;
        long result = 0L;

        while (true)
        {
            while (r < nums.Length && pairs < k)
            {
                dict.TryGetValue(nums[r], out count);
                pairs += count++;
                dict[nums[r]] = count;
                r++;
            }

            if (pairs < k)
            {
                break;
            }

            result += nums.Length - r + 1;

            dict.TryGetValue(nums[l], out count);
            pairs -= --count;
            dict[nums[l]] = count;
            l++;
        }

        return result;
    }
}
// @lc code=end

