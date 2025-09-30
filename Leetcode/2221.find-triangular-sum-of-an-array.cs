/*
 * @lc app=leetcode id=2221 lang=csharp
 *
 * [2221] Find Triangular Sum of an Array 
 */

// @lc code=start
public class Solution {
    public int TriangularSum(int[] nums) {
        int n = nums.Length - 1;

        while (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                nums[i] = (nums[i] + nums[i + 1]) % 10;
            }

            n--;
        }

        return nums[0];
    }
}
// @lc code=end

