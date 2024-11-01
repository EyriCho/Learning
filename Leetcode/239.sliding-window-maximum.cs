/*
 * @lc app=leetcode id=239 lang=csharp
 *
 * [239] Sliding Window Maximum
 */

// @lc code=start
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int targetArrival = times[targetFriend][0];
        Array.Sort(times, (a, b) => a[0] - b[0]);

        PriorityQueue<int, int> available = new ();
        PriorityQueue<(int, int), int> occupied = new ();

        int chair = 0,
            seat = 0;
        foreach (int[] time in times)
        {
            while (occupied.Count > 0 &&
                occupied.Peek().Item1 <= time[0])
            {
                seat = occupied.Dequeue().Item2;
                available.Enqueue(seat, seat);
            }

            seat = available.Count == 0 ? chair++ : available.Dequeue();
            if (time[0] == targetArrival)
            {
                return seat;
            }
            occupied.Enqueue((time[1], seat), time[1]);
        }

        return 0;
    }
}
// @lc code=end

