/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution {
    public int Jump(int[] nums) {
        int step = 0,
            farthest = 0,
            end = 0;
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, nums[i] + i);
            
            if (end == i)
            {
                step++;
                end = farthest;
            }
        }
        
        return step;
    }
}
// @lc code=end

