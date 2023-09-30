/*
 * @lc app=leetcode id=456 lang=csharp
 *
 * [456] 132 Pattern
 */

// @lc code=start
public class Solution {
    public bool Find132pattern(int[] nums) {
        int third = int.MinValue;
        var stack = new Stack<int>();
        for (int i = nums.Length - 1; i > -1; i--)
        {
            if (nums[i] < third)
            {
                return true;
            }
            while (stack.Count > 0 && nums[i] > stack.Peek())
            {
                third = stack.Pop();
            }
            
            stack.Push(nums[i]);
        }
        
        return false;
    }
}
// @lc code=end

