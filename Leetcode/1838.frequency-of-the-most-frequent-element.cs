/*
 * @lc app=leetcode id=1838 lang=csharp
 *
 * [1838] Frequency of the Most Frequent Element
 */

// @lc code=start
public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        if (nums.Length == 1)
        {
            return 1;
        }

        Array.Sort(nums);

        int l = 0,
            r = 1,
            operations = 0,
            result = 1;
        while (r < nums.Length)
        {
            operations += (r - l) * (nums[r] - nums[r - 1]);
            while (operations > k)
            {
                operations -= nums[r] - nums[l++];
            }

            result = Math.Max(result, r - l + 1);

            r++;
        }

        return result;
    }
}
// @lc code=end

