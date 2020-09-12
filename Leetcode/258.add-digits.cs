/*
 * @lc app=leetcode id=258 lang=csharp
 *
 * [258] Add Digits
 */

// @lc code=start
public class Solution {
    public int AddDigits(int num) {
        if (num == 0) return 0;
        var result = num % 9;
        if (result == 0) return 9;
        return result;
    }
}
// @lc code=end

