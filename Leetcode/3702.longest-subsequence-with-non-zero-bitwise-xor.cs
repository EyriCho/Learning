/*
 * @lc app=leetcode id=3702 lang=csharp
 *
 * [3702] Longest Subsequence With Non-Zero Bitwise XOR
 */

// @lc code=start
public class Solution {
    public int LongestSubsequence(int[] nums) {
        int xor = 0;
        bool nonZero = false;
        foreach (int num in nums)
        {
            xor ^= num;
            if (num != 0)
            {
                nonZero = true;
            }
        }

        return (xor, nonZero) switch {
            (0, false) => 0,
            (0, true) => nums.Length - 1,
            _ => nums.Length,
        };
    }
}
// @lc code=end

