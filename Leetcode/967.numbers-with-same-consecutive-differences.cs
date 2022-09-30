/*
 * @lc app=leetcode id=967 lang=csharp
 *
 * [967] Numbers With Same Consecutive Differences
 */

// @lc code=start
public class Solution {
    public int[] NumsSameConsecDiff(int n, int k) {
        var queue = new Queue<int>();
        
        if (N == 1)
        {
            queue.Enqueue(0);
        }
        for (int i = 1; i < 10; i++)
        {
            queue.Enqueue(i);
        }
        
        for (int i = 1; i < N; i++)
        {
            for (int j = queue.Count(); j > 0; j--)
            {
                var val = queue.Dequeue();
                var digit = val % 10;
                if (K == 0)
                {
                    queue.Enqueue(digit + val * 10);
                }
                else
                {
                    if (digit - K >= 0)
                    {
                        queue.Enqueue(digit - K + val * 10);
                    }
                    if (digit + K < 10)
                    {
                        queue.Enqueue(digit + K + val * 10);
                    }
                }
            }
        }
        return queue.ToArray();
    }
}
// @lc code=end

