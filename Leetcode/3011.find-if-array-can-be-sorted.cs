/*
 * @lc app=leetcode id=3011 lang=csharp
 *
 * [3011] Find if Array Can Be Sorted
 */

// @lc code=start
public class Solution {
    public bool CanSortArray(int[] nums) {
        int[] bits = new int[nums.Length];
        int num,
            count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            num = nums[i];
            count = 0;

            while (num > 0)
            {
                num &= num - 1;
                count++;
            }

            bits[i] = count;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (nums[j] > nums[i] &&
                    bits[j] != bits[i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end

