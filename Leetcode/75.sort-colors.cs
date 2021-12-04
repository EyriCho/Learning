/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 */

// @lc code=start
public class Solution {
    public void SortColors(int[] nums) {
        int red = 0, white = 0, blue = 0;
        foreach (var num in nums)
        {
            switch (num)
            {
                case 0:
                    red++;
                    break;
                case 1:
                    white++;
                    break;
                case 2:
                    blue++;
                    break;
            }
        }
        
        Array.Fill(nums, 0, 0, red);
        Array.Fill(nums, 1, red, white);
        Array.Fill(nums, 2, red + white, blue);
    }
}
// @lc code=end

