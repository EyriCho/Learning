/*
 * @lc app=leetcode id=1848 lang=csharp
 *
 * [1848] Minimum Distance to the Target Element
 */

// @lc code=start
public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int result = 0;
        
        while (true)
        {
            if ((start + result < nums.Length && nums[start + result] == target) ||
                (start - result >= 0 && nums[start - result] == target))
            {
                return result;
            }

            result++;
        }

        return 0;
    }
}
// @lc code=end

