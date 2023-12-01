/*
 * @lc app=leetcode id=1887 lang=csharp
 *
 * [1887] Reduction Operations to Make the Array Elements Equal
 */

// @lc code=start
public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);

        int i = nums.Length - 1,
            count = 0,
            result = 0;
        while (i >= 0)
        {
            result += count;

            int num = nums[i--];
            count++;
            while (i >= 0 && nums[i] == num)
            {
                i--;
                count++;
            }
        }

        return result;
    }
}
// @lc code=end

