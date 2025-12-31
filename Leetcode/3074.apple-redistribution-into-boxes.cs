/*
 * @lc app=leetcode id=3074 lang=csharp
 *
 * [3074] Apple Redistribution into Boxes
 */

// @lc code=start
public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int sum = 0;
        foreach (int a in apple)
        {
            sum += a;
        }

        Array.Sort(capacity);
        int r = capacity.Length - 1;
        while (sum > 0)
        {
            sum -= capacity[r] >= sum ? sum : capacity[r];
            r--;
        }

        return capacity.Length - r - 1;
    }
}
// @lc code=end

