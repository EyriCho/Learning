/*
 * @lc app=leetcode id=3513 lang=csharp
 *
 * [3513] Number of Unique XOR Triplets I
 */

// @lc code=start
public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        if (nums.Length < 3)
        {
            return nums.Length;
        }

        uint count = (uint) nums.Length;
        return 1 << (32 - BitOperations.LeadingZeroCount(count));
    }
}
// @lc code=end

