/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        int major = 0, count = 1;
        foreach (var num in nums)
        {
            count += major == num ? 1 : -1;
            if (count == 0)
            {
                major = num;
                count = 1;
            }
        }
        return major;
    }
}
// @lc code=end

