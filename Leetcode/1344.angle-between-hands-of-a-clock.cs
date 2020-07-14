/*
 * @lc app=leetcode id=1344 lang=csharp
 *
 * [1344] Angle Between Hands of a Clock
 */

// @lc code=start
public class Solution {
    public double AngleClock(int hour, int minutes) {
        double hDegree = (hour % 12) * 30 + minutes * 0.5d;
        double mDegree = minutes * 6d;
        double diff = hDegree > mDegree ? hDegree - mDegree : mDegree - hDegree;
        return diff > 180d ? 360d - diff : diff;
    }
}
// @lc code=end

