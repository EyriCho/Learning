/*
 * @lc app=leetcode id=2966 lang=csharp
 *
 * [2966] Divide Array Into Arrays With Max Difference
 */

// @lc code=start
public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);

        int[][] result = new int[nums.Length / 3][];
        for (int i = 0; i < nums.Length; i += 3)
        {
            if (nums[i + 2] - nums[i] > k)
            {
                return new int[0][];
            }

            result[i / 3] = nums[i..(i + 3)];
        }

        return result;
    }
}
// @lc code=end

