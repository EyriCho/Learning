/*
 * @lc app=leetcode id=611 lang=csharp
 *
 * [611] Valid Triangle Number
 */

// @lc code=start
public class Solution {
    public int TriangleNumber(int[] nums) {
        if (nums.Length < 3)
        {
            return 0;
        }

        Array.Sort(nums);
        int result = 0,
            f = 0, s = 0;
            
        for (int third = nums.Length - 1; third > 1; third--)
        {
            f = 0;
            s = third - 1;
            while (f < s)
            {
                if (nums[f] + nums[s] > nums[third])
                {
                    result += s - f;
                    s--;
                }
                else
                {
                    f++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

