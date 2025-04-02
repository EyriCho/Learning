/*
 * @lc app=leetcode id=2033 lang=csharp
 *
 * [2033] Minimum Operations to Make a Uni-Value Grid
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int[] nums = new int[grid.Length * grid[0].Length];
        int remain = grid[0][0] % x;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] % x != remain)
                {
                    return -1;
                }

                nums[i * grid[0].Length + j] = grid[i][j];
            }
        }

        Array.Sort(nums);
        int prefix = 0,
            suffix = 0;
        
        for (int l = 0, r = nums.Length - 1; l < r; l++, r--)
        {
            if (l + 1 < r)
            {
                prefix += (nums[l + 1] - nums[l]) / x * (l + 1);
            }
            suffix += (nums[r] - nums[r - 1]) / x * (nums.Length - r);
        }

        return prefix + suffix;
    }
}
// @lc code=end

