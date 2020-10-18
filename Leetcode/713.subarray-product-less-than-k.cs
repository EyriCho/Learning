/*
 * @lc app=leetcode id=713 lang=csharp
 *
 * [713] Subarray Product Less Than K
 */

// @lc code=start
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k <= 1)
            return 0;
        int product = 1, result = 0;
        int start = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
            while (product >= k)
                product /= nums[start++];
            
            result += i - start + 1;
        }
        
        return result;
    }
}
// @lc code=end

