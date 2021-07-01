/*
 * @lc app=leetcode id=871 lang=csharp
 *
 * [871] Minimum Number of Refueling Stops
 */

// @lc code=start
public class Solution {
    public int MinRefuelStops(int target, int startFuel, int[][] stations) {
        int fuel = startFuel,
            stops = 0;
        
        while (fuel < target)
        {
            int bestStop = -1,
                maxFuel = 0;
            for (int i = 0; i < stations.Length; i++)
            {
                if (stations[i][0] > fuel)
                    break;
                
                if (stations[i][1] > maxFuel)
                {
                    maxFuel = stations[i][1];
                    bestStop = i;
                }
            }
            if (bestStop < 0)
                return -1;
            
            fuel += stations[bestStop][1];
            stations[bestStop][1] = 0;
            stops++;
        }
        
        return stops;
    }
}
// @lc code=end

