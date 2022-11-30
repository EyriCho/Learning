/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 0;
        for (int i = 0; i < nums.Length;)
        {
            nums[j] = nums[i++];
            while (i < nums.Length && nums[i] == nums[j])
            {
                i++;
            }
            j++;
        }
        
        return j;
    }
}
// @lc code=end

