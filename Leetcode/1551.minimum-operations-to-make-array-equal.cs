/*
 * @lc app=leetcode id=1551 lang=csharp
 *
 * [1551] Minimum Operations to Make Array Equal
 */

// @lc code=start
public class Solution {
    public int MinOperations(int n) {
        int t = n / 2;
        return (n % 2 == 0 ? t : (t + 1)) * t;
    }
}
// @lc code=end

