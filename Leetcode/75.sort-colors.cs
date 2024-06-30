/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 */

// @lc code=start
public class Solution {
    public void SortColors(int[] nums) {
        int[] colors = new int[3];

        foreach (int num in nums)
        {
            colors[num]++;
        }
        
        Array.Fill(nums, 0, 0, colors[0]);
        Array.Fill(nums, 1, colors[0], colors[1]);
        Array.Fill(nums, 2, colors[0] + colors[1], colors[2]);
    }
}
// @lc code=end

