/*
 * @lc app=leetcode id=2176 lang=csharp
 *
 * [2176] Count Equal and Divisible Pairs in an Array
 */

// @lc code=start
public class Solution {
    public int CountPairs(int[] nums, int k) {
        int result = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            for (int i = 0; i < j; i++)
            {
                if (nums[i] == nums[j] &&
                    i * j % k == 0)
                {
                    result++;
                }
            }
        }
        return result;
    }
}
// @lc code=end

