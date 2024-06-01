/*
 * @lc app=leetcode id=3068 lang=csharp
 *
 * [3068] Find the Maximum Sum of Node Values
 */

// @lc code=start
public class Solution {
    public long MaximumValueSum(int[] nums, int k, int[][] edges) {
        long sum = 0L;
        int[] delta = nums;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            delta[i] = (nums[i] ^ k) - nums[i];
        }

        Array.Sort(delta);

        for (int i = nums.Length - 2; i >= 0; i -= 2)
        {
            if (delta[i] + delta[i + 1] <= 0)
            {
                break;
            }

            sum += delta[i] + delta[i + 1];
        }

        return sum;
    }
}
// @lc code=end

