/*
 * @lc app=leetcode id=1353 lang=csharp
 *
 * [1353] Maximum Number of Events That Can Be Attended
 */

// @lc code=start
public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        int result = 0,
            day = 0,
            i = 0;

        PriorityQueue<int, int> heap = new ();
        while (heap.Count > 0 || i < events.Length)
        {
            if (heap.Count == 0)
            {
                day = events[i][0];
            }
            while (i < events.Length && events[i][0] <= day)
            {
                heap.Enqueue(events[i][1], events[i][1]);
                i++;
            }
            heap.Dequeue();
            result++;
            day++;
            while (heap.Count > 0 &&
                heap.Peek() < day)
            {
                heap.Dequeue();
            }
        }

        return result;
    }
}
// @lc code=end

