/*
 * @lc app=leetcode id=2145 lang=csharp
 *
 * [2145] Count the Hidden Sequences
 */

// @lc code=start
public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long min = 1,
            max = 1,
            current = 1;
        foreach (int d in differences)
        {
            current += d;
            min = Math.Min(min, current);
            max = Math.Max(max, current);
        }

        max = max + (lower - min);

        return max > upper ? 0 : (int)(upper - max + 1);
    }
}
// @lc code=end

