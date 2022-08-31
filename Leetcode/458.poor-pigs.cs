/*
 * @lc app=leetcode id=458 lang=csharp
 *
 * [458] Poor Pigs
 */

// @lc code=start
public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        var time = minutesToTest / minutesToDie + 1;
        var result = 0;
        while (Math.Pow(time, result) < buckets)
        {
            result++;
        }
        return result;
    }
}
// @lc code=end

