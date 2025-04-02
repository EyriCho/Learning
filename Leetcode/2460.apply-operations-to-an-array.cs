/*
 * @lc app=leetcode id=2460 lang=csharp
 *
 * [2460] Apply Operations to an Array 
 */

// @lc code=start
public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int[] result = new int[nums.Length];
        int r = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                continue;
            }
            else if (i < nums.Length - 1 &&
                nums[i] == nums[i + 1])
            {
                result[r++] = nums[i++] * 2;
            }
            else
            {
                result[r++] = nums[i];
            }
        }

        return result;
    }
}
// @lc code=end

