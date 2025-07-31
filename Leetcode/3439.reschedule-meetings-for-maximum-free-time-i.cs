/*
 * @lc app=leetcode id=3439 lang=csharp
 *
 * [3439] Reschedule Meetings for Maximum Free Time I
 */

// @lc code=start
public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int sum = 0,
            result = 0,
            right = 0,
            left = 0;

        for (int i = k - 2; i >= 0; i--)
        {
            sum += endTime[i] - startTime[i];
        }

        for (int i = k - 1; i < startTime.Length; i++)
        {
            sum += endTime[i] - startTime[i];
            right = i == startTime.Length - 1 ? eventTime : startTime[i + 1];
            left = i == k - 1 ? 0 : endTime[i - k];
            result = Math.Max(result, right - left - sum);

            sum -= endTime[i - k + 1] - startTime[i - k + 1];
        }

        return result;
    }
}
// @lc code=end

