/*
 * @lc app=leetcode id=539 lang=csharp
 *
 * [539] Minimum Time Difference
 */

// @lc code=start
public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        int[] time = new int[timePoints.Count];
        for (int i = 0; i < timePoints.Count; i++)
        {
            time[i] = int.Parse(timePoints[i][0..2]) * 60 + int.Parse(timePoints[i][3..5]);
        }

        Array.Sort(time);
        int result = 1440 - time[time.Length - 1] + time[0];
        for (int i = 1; i < time.Length; i++)
        {
            result = Math.Min(result, time[i] - time[i - 1]);
        }

        return result;
    }
}
// @lc code=end

