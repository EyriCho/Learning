/*
 * @lc app=leetcode id=287 lang=csharp
 *
 * [287] Find the Duplicate Number
 */

// @lc code=start
public class Solution {
    public int FindDuplicate(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            while (nums[i] != i)
            {
                var target = nums[i];
                
                if (nums[target] == target)
                {
                    return target;
                }
                else
                {
                    nums[target] ^= nums[i];
                    nums[i] ^= nums[target];
                    nums[target] ^= nums[i];
                }
            }
        }
        
        return nums[0];
    }
}
// @lc code=end

