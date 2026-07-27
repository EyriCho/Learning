/*
 * @lc app=leetcode id=3691 lang=csharp
 *
 * [3691] Maximum Total Subarray Value II
 */

// @lc code=start
public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        int logn = 32 - BitOperations.LeadingZeroCount((uint)nums.Length);
        int[,] stMax = new int[nums.Length, logn],
            stMin = new int[nums.Length, logn];
        
        for (int i = 0; i < nums.Length; i++)
        {
            stMax[i, 0] = nums[i];
            stMin[i, 0] = nums[i];
        }

        for (int j = 1; j < logn; j++)
        {
            for (int i = 0; i + (1 << j) <= nums.Length; i++)
            {
                stMax[i, j] = Math.Max(stMax[i, j - 1], 
                    stMax[i + (1 << (j - 1)), j - 1]);
                stMin[i, j] = Math.Min(stMin[i, j - 1],
                    stMin[i + (1 << (j - 1)), j - 1]);
            }
        }

        int max = 0, min = 0,
            l = 0, r = 0;
        PriorityQueue<(int l, int r), int> queue = new ();
        for (; l < nums.Length; l++)
        {
            int j = 31 - BitOperations.LeadingZeroCount((uint)(nums.Length - 1 - l + 1));

            max = Math.Max(stMax[l, j], stMax[nums.Length - 1 - (1 << j) + 1, j]);
            min = Math.Min(stMin[l, j], stMin[nums.Length - 1 - (1 << j) + 1, j]);

            queue.Enqueue((l, nums.Length - 1), min - max);
        }

        long result = 0L;
        while (k-- > 0)
        {
            queue.TryDequeue(out var top, out int negVal);
            result -= negVal;

            l = top.l;
            r = top.r;
            if (r > l)
            {
                int j = 31 - BitOperations.LeadingZeroCount((uint)(r - 1 - l + 1));

                max = Math.Max(stMax[l, j], stMax[r - 1 - (1 << j) + 1, j]);
                min = Math.Min(stMin[l, j], stMin[r - 1 - (1 << j) + 1, j]);

                queue.Enqueue((l, r - 1), min - max);
            }
        }

        return result;
    }
}
// @lc code=end

