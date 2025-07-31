/*
 * @lc app=leetcode id=2210 lang=csharp
 *
 * [2210] Count Hills and Valleys in an Array
 */

// @lc code=start
public class Solution {
    public int CountHillValley(int[] nums) {
        int result = 0,
            i = 1,
            current = nums[0];

        while (i < nums.Length && current == nums[i])
        {
            i++;
        }

        if (i == nums.Length)
        {
            return 0;
        }

        bool up = nums[0] < nums[i];

        while (i < nums.Length)
        {
            current = nums[i];
            while (i < nums.Length && nums[i] == current)
            {
                i++;
            }

            if (i == nums.Length)
            {
                return result;
            }
            
            if (up && current > nums[i])
            {
                result++;
            }
            else if (!up && current < nums[i])
            {
                result++;
            }

            up = current < nums[i];
        }

        return result;
    }
}
// @lc code=end

