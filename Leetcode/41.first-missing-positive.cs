/*
 * @lc app=leetcode id=41 lang=csharp
 *
 * [41] First Missing Positive
 */

// @lc code=start
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int temp = 0,
            pos = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] > 0 && nums[i] <= nums.Length)
            {
                pos = nums[i] - 1;

                if (nums[pos] == nums[i])
                {
                    break;
                }

                temp = nums[i];
                nums[i] = nums[pos];
                nums[pos] = temp;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }
        
        return nums.Length + 1;
     }
}
// @lc code=end

