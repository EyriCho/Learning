/*
 * @lc app=leetcode id=1829 lang=csharp
 *
 * [1829] Maximum XOR for Each Query
 */

// @lc code=start
public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int[] result = new int[nums.Length];
        int max = (1 << maximumBit) - 1,
            xor = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            xor ^= nums[i];
            result[nums.Length - 1 - i] = max ^ xor;
        }

        return result;
    }
}
// @lc code=end

