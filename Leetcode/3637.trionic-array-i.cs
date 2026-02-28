/*
 * @lc app=leetcode id=3637 lang=csharp
 *
 * [3637] Trionic Array I
 */

// @lc code=start
public class Solution {
    public bool IsTrionic(int[] nums) {
        if (nums.Length == 3 ||
            nums[1] <= nums[0])
        {
            return false;
        }

        bool isIncreasing = true;
        int directionChange = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                return false;
            }

            if (isIncreasing == nums[i] > nums[i - 1])
            {
                continue;
            }

            if (directionChange++ == 2)
            {
                return false;
            }

            isIncreasing = !isIncreasing;
        }

        return directionChange == 2;
    }
}
// @lc code=end

