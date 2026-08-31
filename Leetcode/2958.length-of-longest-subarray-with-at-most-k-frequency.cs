/*
 * @lc app=leetcode id=2958 lang=csharp
 *
 * [2958] Length of Longest Subarray With at Most K Frequency
 */

// @lc code=start
public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        Dictionary<int, int> frequency = new();

        int l = 0,
            r = 0,
            result = 0;

        while (r < nums.Length)
        {
            frequency.TryGetValue(nums[r], out int c);
            if (c >= k)
            {
                while (nums[l] != nums[r])
                {
                    frequency[nums[l]]--;
                    l++;
                }
                l++;
            }
            else
            {
                frequency[nums[r]] = c + 1;
            }
            
            result = Math.Max(r - l + 1, result);
            r++;
        }

        return result;
    }
}
// @lc code=end

