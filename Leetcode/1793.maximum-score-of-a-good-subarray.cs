/*
 * @lc app=leetcode id=1793 lang=csharp
 *
 * [1793] Maximum Score of a Good Subarray
 */

// @lc code=start
public class Solution {
    public int MaximumScore(int[] nums, int k) {
        Stack<int> left = new(),
            right = new();
        
        left.Push(k);
        for (int l = k; l >= 0; l--)
        {
            if (nums[l] <= nums[left.Peek()])
            {
                left.Push(l);
            }
        }

        right.Push(k);
        for (int r = k; r < nums.Length; r++)
        {
            if (nums[r] <= nums[right.Peek()])
            {
                right.Push(r);
            }
        }

        int i = 0,
            j = nums.Length - 1,
            result = nums[k];
        
        while (i < k || j > k)
        {
            var multi = Math.Min(nums[left.Peek()], nums[right.Peek()]) * (j - i + 1);
            result = Math.Max(result, multi);
            if (j == k || nums[left.Peek()] < nums[right.Peek()])
            {
                i = left.Peek() == k ? k : (left.Peek() + 1);
                left.Pop();
            }
            else if (i == k || nums[left.Peek()] > nums[right.Peek()])
            {
                j = right.Peek() == k ? k : (right.Peek() - 1);
                right.Pop();
            }
            else
            {
                i = left.Peek() == k ? k : (left.Peek() + 1);
                left.Pop();
                j = right.Peek() == k ? k : (right.Peek() - 1);
                right.Pop();
            }
        }

        return result;
    }
}
// @lc code=end

