/*
 * @lc app=leetcode id=80 lang=csharp
 *
 * [80] Remove Duplicates from Sorted Array II
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int s = 0, i = 0,
            p = 0;
        
        while (i < nums.Length)
        {
            p = i;
            nums[s++] = nums[i++];
            
            while (i < nums.Length && nums[i] == nums[i - 1])
            {
                i++;
            }
            
            if (i - p > 1)
            {
                nums[s] = nums[s - 1];
                s++;
            }
        }
        
        return s;
    }
}
// @lc code=end

