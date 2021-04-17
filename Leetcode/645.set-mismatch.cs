/*
 * @lc app=leetcode id=645 lang=csharp
 *
 * [645] Set Mismatch
 */

// @lc code=start
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int temp = 0,
            diff = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i;
            while (nums[j] != j + 1)
            {
                if (nums[nums[j] - 1] == nums[j])
                    break;
                temp = nums[nums[j] - 1];
                nums[nums[j] - 1] = nums[j];
                nums[j] = temp;
            }
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                return new int[] { nums[i], i + 1 };
        }
        
        return new int[] {};
    }
}
// @lc code=end

