/*
 * @lc app=leetcode id=3635 lang=csharp
 *
 * [3635] Earliest Finish Time for Land and Water Rides II
 */

// @lc code=start
public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int landFinish = int.MaxValue,
            waterFinish = int.MaxValue,
            result = int.MaxValue;
        for (int i = 0; i < landStartTime.Length; i++)
        {
            landFinish = Math.Min(landFinish, landStartTime[i] + landDuration[i]);
        }

        for (int i = 0; i < waterStartTime.Length; i++)
        {
            result = Math.Min(result,
                Math.Max(landFinish, waterStartTime[i]) + waterDuration[i]);

            waterFinish = Math.Min(waterFinish, waterStartTime[i] + waterDuration[i]);
        }

        for (int i = 0; i < landStartTime.Length; i++)
        {
            result = Math.Min(result, 
                Math.Max(waterFinish, landStartTime[i]) + landDuration[i]);
        }

        return result;
    }
}
// @lc code=end

