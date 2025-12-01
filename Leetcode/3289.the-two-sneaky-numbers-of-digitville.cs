/*
 * @lc app=leetcode id=3289 lang=csharp
 *
 * [3289] The Two Sneaky Numbers of Digitville
 */

// @lc code=start
public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] result = new int[2];
        int count = 0, 
            num = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            num = nums[i];

            while (num >= 0 && (nums[num] >= -1 || nums[num] == int.MinValue))
            {
                if (nums[num] == -1)
                {
                    result[count++] = num;
                    nums[i] = int.MinValue;
                    break;
                }

                nums[i] = nums[num];
                nums[num] = -1;
                num = nums[i];
            }
        }

        return result;
    }
}
// @lc code=end

