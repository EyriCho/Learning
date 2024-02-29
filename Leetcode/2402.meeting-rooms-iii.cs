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

        Array.Sort(meetings, (a, b) => a[0] - b[0]);
        long minTime = 0L;
        int room = 0;
        foreach (int[] meeting in meetings)
        {
            minTime = long.MaxValue;
            room = 0;;

            for (int i = 0; i < n; i++)
            {
                if (endTimes[i] <= meeting[0])
                {
                    room = i;
                    break;
                }

                if (minTime > endTimes[i])
                {
                    room = i;
                    minTime = endTimes[i];
                }
            }

            rooms[room]++;
            endTimes[room] = endTimes[room] > meeting[0] ?
                endTimes[room] + meeting[1] - meeting[0] :
                meeting[1];
        }

        int max = 0,
            result = 0;
        for (int i = 0; i < n; i++)
        {
            if (rooms[i] > max)
            {
                max = rooms[i];
                result = i;
            }
        }
        return result;
    }
}
// @lc code=end

