/*
 * @lc app=leetcode id=3379 lang=csharp
 *
 * [3379] Transformed Array
 */

// @lc code=start
public class Solution {
    public int[] ConstructTransformedArray(int[] nums) {
        int[] result = new int[nums.Length];
        int idx = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            idx = (i + nums[i] % nums.Length + nums.Length) % nums.Length;
            result[i] = nums[idx];
        }
        return result;
    }
}
// @lc code=end

