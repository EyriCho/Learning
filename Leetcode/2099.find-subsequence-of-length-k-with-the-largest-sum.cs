/*
 * @lc app=leetcode id=2099 lang=csharp
 *
 * [2099] Find Subsequence of Length K With the Largest Sum
 */

// @lc code=start
public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        if (k == nums.Length)
        {
            return nums;
        }

        PriorityQueue<int, int> queue = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(i, nums[i]);
            if (queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = queue.Dequeue();
        }
        Array.Sort(result);
        for (int i = 0; i < k; i++)
        {
            result[i] = nums[result[i]];
        }
        return result;
    }
}
// @lc code=end

