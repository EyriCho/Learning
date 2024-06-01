/*
 * @lc app=leetcode id=1608 lang=csharp
 *
 * [1608] Special Array With X Elements Greater Than or Equal X
 */

// @lc code=start
public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);

        int x = 0;
        for (int i = nums.Length - 1; i > -1; i--)
        {
            x = nums.Length - i;
            if (x <= nums[i] &&
                (i == 0 || nums[i - 1] < x))
            {
                return x;
            }
        }
        
        return -1;
    }
}
// @lc code=end

