/*
 * @lc app=leetcode id=3362 lang=csharp
 *
 * [3362] Zero Array Transformation III
 */

// @lc code=start
public class Solution {
    public int MaxRemoval(int[] nums, int[][] queries) {
        Array.Sort(queries, (a, b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> queue = new ();
        int[] decrease = new int[nums.Length + 1];
        int ops = 0;
        for (int i = 0, q = 0; i < nums.Length; i++)
        {
            ops += decrease[i];
            while (q < queries.Length && queries[q][0] == i)
            {
                queue.Enqueue(queries[q][1], -queries[q][1]);
                q++;
            }

            while (ops < nums[i] &&
                queue.Count > 0 &&
                queue.Peek() >= i)
            {
                decrease[queue.Dequeue() + 1]--;
                ops++;
            }

            if (ops < nums[i])
            {
                return -1;
            }
        }
        return queue.Count;
    }
}
// @lc code=end

