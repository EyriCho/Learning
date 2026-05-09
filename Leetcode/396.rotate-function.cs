/*
 * @lc app=leetcode id=396 lang=csharp
 *
 * [396] Rotate Function
 */

// @lc code=start
public class Solution {
    public int MaxRotateFunction(int[] nums) {
        int result = 0,
            total = 0,
            current = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            total += nums[i];
            current += i * nums[i];
        }
        result = current;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            current += total - nums.Length * nums[i];
            result = Math.Max(result, current);
        }
        return result;
    }
}
// @lc code=end

