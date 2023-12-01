/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [2849] Determine if a Cell Is Reachable at a Given Time
 */

// @lc code=start
public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        if (sx == fx && sy == fy)
        {
            return t != 1;
        }

        return Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy)) <= t;
    }
}
// @lc code=end

