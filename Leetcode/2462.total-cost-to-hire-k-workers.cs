/*
 * @lc app=leetcode id=2462 lang=csharp
 *
 * [2462] Total Cost to Hire K Workers
 */

// @lc code=start
public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        var result = 0L;

        if (candidates * 2 > costs.Length - k || costs.Length == k)
        {
            Array.Sort(costs);
            for (int i = 0; i < k; i++)
            {
                result += costs[i];
            }
            return result;
        }

        var queue = new PriorityQueue<int, (int, int)>(candidates * 2,
            Comparer<(int, int)>.Create((a, b) => 
                a.Item1 == b.Item1 ? a.Item2 - b.Item2 : a. Item1 - b.Item1));
        for (int i = 0; i < candidates; i++)
        {
            queue.Enqueue(i, (costs[i], i));
            var r = costs.Length - 1 - i;
            queue.Enqueue(r, (costs[r], r));
        }

        int left = candidates, right = costs.Length - candidates;
        while (k-- > 0)
        {
            var idx = queue.Dequeue();
            result += costs[idx];

            if (left < right)
            {
                if (idx < left)
                {
                    queue.Enqueue(left, (costs[left], left));
                    left++;
                }
                else
                {
                    right--;
                    queue.Enqueue(right, (costs[right], right));
                }
            }
        }

        return result;
    
    }
}
// @lc code=end

