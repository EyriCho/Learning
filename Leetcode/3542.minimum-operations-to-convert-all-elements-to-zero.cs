/*
 * @lc app=leetcode id=3542 lang=csharp
 *
 * [3542] Minimum Operations to Convert All Elements to Zero
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        Stack<int> stack = new ();
        int result = 0;
        foreach (int num in nums)
        {
            while (stack.Count > 0 && stack.Peek() > num)
            {
                stack.Pop();
            }

            if (num == 0)
            {
                continue;
            }

            if (stack.Count == 0 || stack.Peek() < num)
            {
                result++;
                stack.Push(num);
            }
        }

        return result;
    }
}
// @lc code=end

