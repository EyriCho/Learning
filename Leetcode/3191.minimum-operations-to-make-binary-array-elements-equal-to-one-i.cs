/*
 * @lc app=leetcode id=3191 lang=csharp
 *
 * [3191] Minimum Operations to Make Binary Array Elements Equal to One I
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        int bits = nums[0] << 1 | nums[1],
            ops = 0;

        for (int i = 2; i < nums.Length; i++)
        {
            bits = (bits << 1 | nums[i]) & 7;
            if (bits < 4)
            {
                ops++;
                bits ^= 7;
            }
        }

        return bits switch {
            0 => ops + 1,
            7 => ops,
            _ => -1,
        };
    }
}
// @lc code=end

