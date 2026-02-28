/*
 * @lc app=leetcode id=2943 lang=csharp
 *
 * [2943] Maximize Area of Square Hole in Grid
 */

// @lc code=start
public class Solution {
    public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars) {
        Array.Sort(hBars);
        Array.Sort(vBars);

        int count = 1,
            hMax = 1,
            vMax = 1;

        for (int i = 1; i < hBars.Length; i++)
        {
            if (hBars[i] == hBars[i - 1] + 1)
            {
                count++;
                hMax = Math.Max(hMax, count);
            }
            else
            {
                count = 1;
            }
        }

        count = 1;
        for (int i = 1; i < vBars.Length; i++)
        {
            if (vBars[i] == vBars[i - 1] + 1)
            {
                count++;
                vMax = Math.Max(vMax, count);
            }
            else
            {
                count = 1;
            }
        }

        int maxSide = Math.Min(hMax, vMax) + 1;
        return maxSide * maxSide;
    }
}
// @lc code=end

