/*
 * @lc app=leetcode id=3264 lang=csharp
 *
 * [3264] Find Array State After K Multiplication Operations I
 */

// @lc code=start
public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int min = 0,
            idx = 0;
        while (k-- > 0)
        {
            idx = 0;
            
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[idx])
                {
                    idx = i;
                }
            }
            
            nums[idx] *= multiplier;
        }

        return nums;
    }
}
// @lc code=end

