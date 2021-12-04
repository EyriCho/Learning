/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        int[] max = new int[nums.Length],
            min = new int[nums.Length];
        max[0] = min[0] = nums[0];
        
        int result = max[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                max[i] = 0;
                min[i] = 0;
            }
            else
            {
                int maxProduct = max[i - 1] * nums[i],
                    minProduct = min[i - 1] * nums[i];
                max[i] = Math.Max(Math.Max(minProduct, maxProduct), nums[i]);
                min[i] = Math.Min(Math.Min(minProduct, maxProduct), nums[i]);
            }
            
            result = Math.Max(result, max[i]);
        }
        
        return result;
    }
}
// @lc code=end

