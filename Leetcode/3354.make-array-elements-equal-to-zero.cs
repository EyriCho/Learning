/*
 * @lc app=leetcode id=3354 lang=csharp
 *
 * [3354] Make Array Elements Equal to Zero
 */

// @lc code=start
public class Solution {
    public int CountValidSelections(int[] nums) {
        int[] cumulative = new int[nums.Length];
        cumulative[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            cumulative[i] = cumulative[i - 1] + nums[i];
        }

        int total = 0,
            result = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            total += nums[i];
            
            if (nums[i] != 0)
            {
                continue;
            }

            if (total == cumulative[i])
            {
                result += 2;
            }
            if (total == cumulative[i] + 1 ||
                total == cumulative[i] - 1)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

