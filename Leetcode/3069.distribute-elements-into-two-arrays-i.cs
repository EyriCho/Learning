/*
 * @lc app=leetcode id=3069 lang=csharp
 *
 * [3069] Distribute Elements Into Two Arrays I
 */

// @lc code=start
public class Solution {
    public int[] ResultArray(int[] nums) {
        int[] result = new int[nums.Length];
        int i1 = 0, i2 = nums.Length - 1;
        result[i1] = nums[0];
        result[i2] = nums[1];

        for (int i = 2; i < nums.Length; i++)
        {
            if (result[i1] > result[i2])
            {
                result[++i1] = nums[i];
            }
            else
            {
                result[--i2] = nums[i];
            }
        }

        Array.Reverse(result, i2, nums.Length - i2);
        
        return result;
    }
}
// @lc code=end

