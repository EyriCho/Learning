/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums?.Any() != true) return 0;
        int index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[index] != nums[i])
            {
                index++;
                if (index < i)
                    nums[index] = nums[i];
            }
        }
        return index + 1;
    }
}
// @lc code=end

