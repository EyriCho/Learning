/*
 * @lc app=leetcode id=3440 lang=csharp
 *
 * [3440] Reschedule Meetings for Maximum Free Time II
 */

// @lc code=start
public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        bool[] canMove = new bool[startTime.Length];
        int lMax = 0, rMax = 0;
        for (int l = 0, r = startTime.Length - 1; l < startTime.Length; l++, r--)
        {
            if (lMax >= endTime[l] - startTime[l])
            {
                canMove[l] = true;
            }
            lMax = Math.Max(lMax, startTime[l] - (l == 0 ? 0 : endTime[l - 1]));

            if (rMax >= endTime[r] - startTime[r])
            {
                canMove[r] = true;
            }
            rMax = Math.Max(rMax, (l == 0 ? eventTime : startTime[r + 1]) - endTime[r]);
        }

        int result = 0, gap = 0;
        for (int i = 0; i < startTime.Length; i++)
        {
            gap = (i == startTime.Length - 1 ? eventTime : startTime[i + 1]) - 
                (i == 0 ? 0 : endTime[i - 1]);

            result = Math.Max(result, gap - (canMove[i] ? 0 : endTime[i] - startTime[i]));
        }

        return result;
    }
}
// @lc code=end

