/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */

// @lc code=start
public class Solution {
    public int PivotIndex(int[] nums) {
        int total = 0,
            sum = 0;

        foreach (int num in nums)
        {
            total += num;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            total -= nums[i];
            if (sum == total)
            {
                return i;
            }
            sum += nums[i];
        }

        return -1;
    }
}
// @lc code=end

