/*
 * @lc app=leetcode id=2402 lang=csharp
 *
 * [2402] Meeting Rooms III
 */

// @lc code=start
public class Solution {
    public int MostBooked(int n, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        long[] roomAvailableTimes = new long[n];
        int[] held = new int[n];

        long availableTime = 0L;
        int availableRoom = 0;
        bool foundRoomBeforeStart = false;
        foreach (int[] meeting in meetings)
        {
            availableTime = long.MaxValue;
            availableRoom = 0;
            foundRoomBeforeStart = false;

            for (int r = 0; r < n; r++)
            {
                if (roomAvailableTimes[r] <= meeting[0])
                {
                    foundRoomBeforeStart = true;
                    roomAvailableTimes[r] = meeting[1];
                    held[r]++;
                    break;
                }

                if (availableTime > roomAvailableTimes[r])
                {
                    availableTime = roomAvailableTimes[r];
                    availableRoom = r;
                }
            }

            if (!foundRoomBeforeStart)
            {
                roomAvailableTimes[availableRoom] += meeting[1] - meeting[0];
                held[availableRoom]++;
            }
        }

        int result = 0,
            maxHeld = held[0];
        for (int r = 1; r < n; r++)
        {
            if (held[r] > maxHeld)
            {
                result = r;
                maxHeld = held[r];
            }
        }
        return result;
    }
}
// @lc code=end

