/*
 * @lc app=leetcode id=3347 lang=csharp
 *
 * [3347] Maximum Frequency of an Element After Performing Operations II
 */

// @lc code=start
public class Solution {
    public int MaxFrequency(int[] nums, int k, int numOperations) {
        if (nums.Length == 1)
        {
            return 1;
        }
        Array.Sort(nums);

        int result = 0,
            left = 0, right = 0,
            min = 0, max = 0,
            freq = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            max = nums[i] + k * 2;

            while (right < nums.Length && nums[right] <= max)
            {
                right++;
            }

            result = Math.Max(result, right - i);
        }
        result = Math.Min(result, numOperations);

        left = 0;
        right = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            freq = (i > 0 && nums[i] == nums[i - 1]) ? freq + 1 : 1;

            min = nums[i] - k;
            max = nums[i] + k;
            while (true)
            {
                if (left < nums.Length && nums[left] < min)
                {
                    left++;
                }
                else if (right < nums.Length && nums[right] <= max)
                {
                    right++;
                }
                else
                {
                    break;
                }
            }

            result = Math.Max(result, Math.Min(freq + numOperations, right - left));
        }

        return result;
    }
}
// @lc code=end

