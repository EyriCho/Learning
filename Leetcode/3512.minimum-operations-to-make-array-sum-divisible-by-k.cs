/*
 * @lc app=leetcode id=3512 lang=csharp
 *
 * [3512] Minimum Operations to Make Array Sum Divisible by K
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int k) {
        int left = 0;
        foreach (int num in nums)
        {
            left = (left + num) % k;
        }
        return left;
    }
}
// @lc code=end

