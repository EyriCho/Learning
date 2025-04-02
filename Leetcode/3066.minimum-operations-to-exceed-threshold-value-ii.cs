/*
 * @lc app=leetcode id=3066 lang=csharp
 *
 * [3066] Minimum Operations to Exceed Threshold Value II
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int k) {
        PriorityQueue<long, long> queue = new ();
        foreach (int num in nums)
        {
            queue.Enqueue(num, num);
        }

        int result = 0;
        long x = 0,
            y = 0;
        while (queue.Count > 1)
        {
            x = queue.Dequeue();
            if (x >= k)
            {
                return result;
            }
            
            result++;
            y = queue.Dequeue();
            x = x * 2 + y;
            queue.Enqueue(x, x);
        }
        return result;
    }
}
// @lc code=end

