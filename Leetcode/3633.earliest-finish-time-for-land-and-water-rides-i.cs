/*
 * @lc app=leetcode id=3633 lang=csharp
 *
 * [3633] Earliest Finish Time for Land and Water Rides I
 */

// @lc code=start
public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int result = int.MaxValue,
            landEndTime = 0,
            waterEndTime = 0;

        for (int i = 0; i < landStartTime.Length; i++)
        {
            landEndTime = landStartTime[i] + landDuration[i];
            for (int j = 0; j < waterStartTime.Length; j++)
            {
                waterEndTime = waterStartTime[j] + waterDuration[j];

                if (landEndTime >= waterStartTime[j])
                {
                    result = Math.Min(result, landEndTime + waterDuration[j]);
                }
                else
                {
                    result = Math.Min(result, waterEndTime);
                }

                if (landStartTime[i] <= waterEndTime)
                {
                    result = Math.Min(result, waterEndTime + landDuration[i]);
                }
                else
                {
                    result = Math.Min(result, landEndTime);
                }
            }
        }

        return result;
    }
}
// @lc code=end

