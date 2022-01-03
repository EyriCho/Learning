/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfTwo(int n) {
        return n > 0 && (n & (n - 1)) == 0;
    }
}
// @lc code=end

