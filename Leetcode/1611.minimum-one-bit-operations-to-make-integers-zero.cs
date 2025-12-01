/*
 * @lc app=leetcode id=1611 lang=csharp
 *
 * [1611] Minimum One Bit Operations to Make Integers Zero
 */

// @lc code=start
public class Solution {
    public int MinimumOneBitOperations(int n) {
        // Same as Gray Code Sequence, 
        // Convert it back to Binary Known is Position
        int result = 0;
        while (n > 0)
        {
            result ^= n;
            n >>= 1;
        }
        return result;
    }
}
// @lc code=end

