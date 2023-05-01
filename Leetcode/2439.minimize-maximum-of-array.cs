/*
 * @lc app=leetcode id=2439 lang=csharp
 *
 * [2439] Minimize Maximum of Array
 */

// @lc code=start
public class Solution {
    public int MinimizeArrayValue(int[] nums) {
        var result = 0;
        var stack = new Stack<(int, long, int)>();

        int i = 0;
        while (i < nums.Length)
        {
            int l = i,
                prev = nums[i];
            var total = 0L;
            while (i < nums.Length && nums[i] >= prev)
            {
                total += nums[i];
                prev = nums[i++];
            }

            var length = i - l;
            var max = (int)(total / length) + (total % length > 0 ? 1 : 0);
            while (stack.Count > 0 && max >= stack.Peek().Item3)
            {
                var (len, t, m) = stack.Pop();
                length += len;
                total += t;
                max = (int)(total / length) + (total % length > 0 ? 1 : 0);
            }

            result = Math.Max(max, result);
            stack.Push((length, total, max));
        }

        return result;
    }
}
// @lc code=end

