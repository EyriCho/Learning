/*
 * @lc app=leetcode id=2402 lang=csharp
 *
 * [2402] Meeting Rooms III
 */

// @lc code=start
public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        int[] rooms = new int[n];
        long[] endTimes = new long[n];
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> occupied = new (Comparer<int>.Create((a, b) =>
            endTimes[a] == endTimes[b] ? a.CompareTo(b) : endTimes[a].CompareTo(endTimes[b])));
        SortedSet<int> frees = new ();
        for (int i = 0; i < n; i++)
        {
            frees.Add(i);
        }
        
        int free = 0;
        long delayTime = 0L;
        for (int i = 0; i < meetings.Length; i++)
        {
            while (occupied.Count > 0 &&
                endTimes[occupied.Peek()] <= meetings[i][0])
            {
                frees.Add(occupied.Dequeue());
            }
            if (occupied.Count == n)
            {
                delayTime = endTimes[occupied.Peek()] - meetings[i][0];
                frees.Add(occupied.Dequeue());
            }
            else
            {
                delayTime = 0L;
            }
            free = frees.Min;
            rooms[free]++;
            endTimes[free] = delayTime + meetings[i][1];
            frees.Remove(free);
            occupied.Enqueue(free, free);
        }

        int result = 0;
        for (int i = 1; i < n; i++)
        {
            if (rooms[i] > rooms[result])
            {
                result = i;
            }
        }

        return result;
    }
}
// @lc code=end

