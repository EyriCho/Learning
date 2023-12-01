/*
 * @lc app=leetcode id=2391 lang=csharp
 *
 * [2391] Minimum Amount of Time to Collect Garbage
 */

// @lc code=start
public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int[] travelTimes = new int[3];
        int travelTime = 0,
            result = garbage[0].Length;

        for (int i = 1; i < garbage.Length; i++)
        {
            travelTime += travel[i - 1];
            result += garbage[i].Length;
            if (garbage[i].Contains('M'))
            {
                travelTimes[0] = travelTime;
            }

            if (garbage[i].Contains('P'))
            {
                travelTimes[1] = travelTime;
            }

            if (garbage[i].Contains('G'))
            {
                travelTimes[2] = travelTime;
            }
        }

        foreach (int t in travelTimes)
        {
            result += t;
        }

        return result;
    }
}
// @lc code=end

