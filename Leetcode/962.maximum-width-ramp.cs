/*
 * @lc app=leetcode id=962 lang=csharp
 *
 * [962] Maximum Width Ramp
 */

// @lc code=start
public class Solution {
    public int MaxWidthRamp(int[] nums) {
        int result = 0;
        Stack<int> stack = new ();

        for (int i = 0; i < nums.Length; i++)
        {
            if (stack.Count == 0 ||
                nums[stack.Peek()] > nums[i])
            {
                stack.Push(i);
            }
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 &&
                nums[stack.Peek()] <= nums[i])
            {
                result = Math.Max(result, i - stack.Pop());
            }

            if (stack.Count == 0)
            {
                break;
            }
        }

        return result;
    }
}
// @lc code=end

