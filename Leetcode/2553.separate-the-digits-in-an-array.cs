/*
 * @lc app=leetcode id=2553 lang=csharp
 *
 * [2553] Separate the Digits in an Array
 */

// @lc code=start
public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> list = new ();
        Stack<int> stack = new ();

        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] > 0)
            {
                stack.Push(nums[i] % 10);
                nums[i] /= 10;
            }

            while(stack.Count > 0)
            {
                list.Add(stack.Pop());
            }
        }

        return list.ToArray();
    }
}
// @lc code=end

