/*
 * @lc app=leetcode id=1503 lang=csharp
 *
 * [1503] Last Moment Before All Ants Fall Out of a Plank
 */

// @lc code=start
public class Solution {
    public int GetLastMoment(int n, int[] left, int[] right) {
        int result = 0;

        foreach (var l in left)
        {
            result = Math.Max(result, l);
        }

        foreach (var r in right)
        {
            result = Math.Max(result, n - r);
        }

        return result;
    }
}
// @lc code=end

