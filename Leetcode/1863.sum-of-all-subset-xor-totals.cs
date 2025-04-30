/*
 * @lc app=leetcode id=1863 lang=csharp
 *
 * [1863] Sum of All Subset XOR Totals
 */

// @lc code=start
public class Solution {
    public int SubsetXORSum(int[] nums) {
        int or = 0;
        foreach (int num in nums)
        {
            or |= num;
        }

        return or << (nums.Length - 1);
    }
}
// @lc code=end

