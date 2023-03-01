/*
 * @lc app=leetcode id=1523 lang=csharp
 *
 * [1523] Count Odd Numbers in an Interval Range
 */

// @lc code=start
public class Solution {
    public int CountOdds(int low, int high) {
        var count = high - low + 1;
        if (count % 2 == 1 && low % 2 == 1)
        {
            return count / 2 + 1;
        }
        else
        {
            return count / 2;
        }
    }
}
// @lc code=end

