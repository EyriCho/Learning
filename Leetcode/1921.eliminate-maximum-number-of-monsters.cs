/*
 * @lc app=leetcode id=1921 lang=csharp
 *
 * [1921] Eliminate Maximum Number of Monsters
 */

// @lc code=start
public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        int[] arrivalTimes = new int[dist.Length];

        for (int i = 0; i < dist.Length; i++)
        {
            int time = (dist[i] - 1) / speed[i];
            if (time < dist.Length)
            {
                arrivalTimes[time]++;
            }
        }

        int kill = 0;
        for (int i = 0; i < dist.Length; i++)
        {
            kill++;
            kill -= arrivalTimes[i];
            if (kill < 0)
            {
                return i + 1;
            }
        }

        return dist.Length;
    }
}
// @lc code=end

