/*
 * @lc app=leetcode id=2997 lang=csharp
 *
 * [2997] Minimum Number of Operations to Make Array XOR Equal to K
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int k) {
        int xor = k;
        foreach (int num in nums)
        {
            xor ^= num;
        }

        int result = 0;
        while (xor > 0)
        {
            xor &= (xor - 1);
            result++;
        }

        return result;
    }
}
// @lc code=end

