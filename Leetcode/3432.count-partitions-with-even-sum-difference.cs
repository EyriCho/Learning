/*
 * @lc app=leetcode id=3432 lang=csharp
 *
 * [3432] Count Partitions with Even Sum Difference
 */

// @lc code=start
public class Solution {
    public int CountPartitions(int[] nums) {
        int last = 0;
        foreach (int num in nums)
        {
            last ^= num & 1;
        }

        return last == 1 ? 0 : (nums.Length - 1);
    }
}
// @lc code=end

