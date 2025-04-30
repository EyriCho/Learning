/*
 * @lc app=leetcode id=2845 lang=csharp
 *
 * [2845] Count of Interesting Subarrays
 */

// @lc code=start
public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        long result = 0L;
        int count = 0,
            countMod = 0,
            prev = 0;
        Dictionary<int, int> dict = new () {
            { 0, 1 },
        };

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % modulo == k)
            {
                count++;
            }

            dict.TryGetValue((count + modulo - k) % modulo, out prev);
            result += prev;
            countMod = count % modulo;
            dict.TryGetValue(countMod, out prev);
            dict[countMod] = prev + 1;
        }

        return result;
    }
}
// @lc code=end

