/*
 * @lc app=leetcode id=1326 lang=csharp
 *
 * [1326] Minimum Number of Taps to Open to Water a Garden
 */

// @lc code=start
public class Solution {
    public int MinTaps(int n, int[] ranges) {
        var maxReach = new int[ranges.Length];

        for (int i = 0; i < ranges.Length; i++)
        {
            int left = Math.Max(i - ranges[i], 0),
                right = Math.Min(i + ranges[i], n);
            maxReach[left] = Math.Max(right, maxReach[left]);
        }

        int result = 0,
            current = 0,
            next = 0;

        for (int i = 0; i < maxReach.Length; i++)
        {
            if (i > next)
            {
                return -1;
            }

            if (i > current)
            {
                current = next;
                result++;
            }

            next = Math.Max(next, maxReach[i]);
        }

        return result;
    }
}
// @lc code=end

