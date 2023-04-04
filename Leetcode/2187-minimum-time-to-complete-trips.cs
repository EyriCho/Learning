/*
 * @lc app=leetcode id=2187 lang=csharp
 *
 * [2187] Minimum Time to Complete Trips
 */

// @lc code=start
public class Solution {
    public long MinimumTime(int[] time, int totalTrips) {
        var min = time[0];
        for (int i = 1; i < time.Length; i++)
        {
            min = Math.Min(min, time[i]);
        }

        long l = 1L,
            r = min * (long)totalTrips;

        while (l < r)
        {
            var mid = (l + r) >> 1;
            var trip = 0L;
            foreach (var t in time)
            {
                trip += mid / t;
            }
            
            if (trip < totalTrips)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }
        return l;
    }
}
// @lc code=end

