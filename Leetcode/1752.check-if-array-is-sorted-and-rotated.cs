/*
 * @lc app=leetcode id=1752 lang=csharp
 *
 * [1752] Check if Array Is Sorted and Rotated
 */

// @lc code=start
public class Solution {
    public bool Check(int[] nums) {
        bool isRotate = false;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                if (isRotate)
                {
                    return false;
                }

                isRotate = true;
            }
        }

        return !isRotate || nums[0] >= nums[^1];
    }
}
// @lc code=end

