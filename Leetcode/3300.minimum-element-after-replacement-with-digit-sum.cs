/*
 * @lc app=leetcode id=3300 lang=csharp
 *
 * [3300] Minimum Element After Replacement With Digit Sum
 */

// @lc code=start
public class Solution {
    public int MinElement(int[] nums) {
        int result = int.MaxValue,
            sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = 0;
            while (nums[i] > 0)
            {
                sum += nums[i] % 10;
                nums[i] /= 10;
            }
            result = Math.Min(result, sum);
        }

        return result;
    }
}
// @lc code=end

