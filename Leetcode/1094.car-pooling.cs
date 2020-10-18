/*
 * @lc app=leetcode id=1094 lang=csharp
 *
 * [1094] Car Pooling
 */

// @lc code=start
public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        int[] pick = new int[1001], drop = new int[1001];
        int sum = 0;
        for (int i = 0; i < trips.Length; i++)
        {
            pick[trips[i][1]] += trips[i][0];
            drop[trips[i][2]] += trips[i][0];
        }
        for (int i = 0; i < 1001; i++)
        {
            sum += pick[i];
            sum -= drop[i];
            if (sum > capacity)
                return false;
        }
        
        return true;
    }
}
// @lc code=end

