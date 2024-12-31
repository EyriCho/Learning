/*
 * @lc app=leetcode id=1014 lang=csharp
 *
 * [1014] Best Sightseeing Pair
 */

// @lc code=start
public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int idx = 0,
            max = 1;

        for (int i = 1; i < values.Length; i++)
        {
            max = Math.Max(max, values[i] + values[idx] - i + idx);
            if (values[i] + i > values[idx] + idx)
            {
                idx = i;
            }
        }

        return max;
    }
}
// @lc code=end

