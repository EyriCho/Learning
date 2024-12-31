/*
 * @lc app=leetcode id=2054 lang=csharp
 *
 * [2054] Two Best Non-Overlapping Events
 */

// @lc code=start
public class Solution {
    public int MaxTwoEvents(int[][] events) {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        int l = 0,
            r = 0,
            prevMax = 0,
            max = 0;

        PriorityQueue<int[], int> queue = new ();

        while (r < events.Length)
        {
            while (queue.Count > 0 &&
                events[r][0] > queue.Peek()[1])
            {
                prevMax = Math.Max(prevMax, queue.Dequeue()[2]);
            }
            queue.Enqueue(events[r], events[r][1]);

            max = Math.Max(max, prevMax + events[r++][2]);
        }

        return max;
    }
}
// @lc code=end

