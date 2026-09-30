/*
 * @lc app=leetcode id=3550 lang=csharp
 *
 * [3550] Smallest Index With Digit Sum Equal to Index
 */

// @lc code=start
public class Solution {
    public int SmallestIndex(int[] nums) {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum = 0;
            while (nums[i] > 0)
            {
                sum += nums[i] % 10;
                nums[i] /= 10;
            }

            if (sum == i)
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

