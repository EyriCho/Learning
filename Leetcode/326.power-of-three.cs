/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfThree(int n) {
        // maximum power of three 1162261467
        return n > 0 &&
            1_162_261_467 % n == 0;
    }
}
// @lc code=end

