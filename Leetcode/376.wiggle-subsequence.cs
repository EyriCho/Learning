/*
 * @lc app=leetcode id=376 lang=csharp
 *
 * [376] Wiggle Subsequence
 */

// @lc code=start
public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if (nums.Length == 1)
            return 1;
        
        int result = nums.Length;
        int i = 1;
        while (i < nums.Length && nums[i] == nums[i - 1])
        {
            result--;
            i++;
        }
        if (i == nums.Length)
            return 1;
        bool isUp = nums[i] > nums[i - 1];
        
        for (i++; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                result--;
            else if(isUp && nums[i] > nums[i - 1])
                result--;
            else if (!isUp && nums[i] < nums[i - 1])
                result--;
            else
                isUp = !isUp;
        }
        
        return result;
    }
}
// @lc code=end

