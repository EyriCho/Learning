/*
 * @lc app=leetcode id=2780 lang=csharp
 *
 * [2780] Minimum Index of a Valid Split
 */

// @lc code=start
public class Solution {
    public int MinimumIndex(IList<int> nums) {
        int count = 0,
            dominant = nums[0];
        foreach (int num in nums)
        {
            if (dominant == num)
            {
                count++;
            }
            else if (count == 1)
            {
                dominant = num; 
            }
            else
            {
                count--;
            }
        }

        int left = 0,
            right = 0;
        foreach (int num in nums)
        {
            if (num == dominant)
            {
                right++;
            }
        }

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == dominant)
            {
                left++;
                right--;
            }

            if (left * 2 > (i + 1) && right * 2 > (nums.Count - 1 - i))
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

