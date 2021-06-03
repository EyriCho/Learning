/*
 * @lc app=leetcode id=665 lang=csharp
 *
 * [665] Non-decreasing Array
 */

// @lc code=start
public class Solution {
    public bool CheckPossibility(int[] nums) {
        bool hasDecrease = false;
        int prev = -100_001;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                if (hasDecrease)
                    return false;
                
                hasDecrease = true;
                if (nums[i] >= prev)
                    nums[i - 1] = nums[i];
                else
                    nums[i] = nums[i - 1];
            }
            
            prev = nums[i - 1];
        }
        return true;
    }
}
// @lc code=end

