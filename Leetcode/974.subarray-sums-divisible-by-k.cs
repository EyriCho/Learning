/*
 * @lc app=leetcode id=974 lang=csharp
 *
 * [974] Subarray Sums Divisible by K
 */

// @lc code=start
public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        Dictionary<int, int> dict = new () {
            { 0, 1 }
        };
        int result = 0,
            total = 0,
            left = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            total += nums[i];
            left = (total % k + k) % k;

            dict.TryGetValue(left, out int count);
            result += count;
            dict[left] = count + 1;
        }

        return result;
    }
}
// @lc code=end

