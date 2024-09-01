/*
 * @lc app=leetcode id=719 lang=csharp
 *
 * [719] Find K-th Smallest Pair Distance
 */

// @lc code=start
public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int l = 0,
            r = nums[nums.Length - 1] - nums[0],
            m = 0,
            count = 0,
            result = 0,
            j = 0;
        
        while (l <= r)
        {
            m = (l + r) >> 1;
            count = 0;
            j = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                while (j < nums.Length && nums[j] - nums[i] <= m)
                {
                    j++;
                }
                count += j - i - 1;
            }

            if (count < k)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
                result = m;
            }
        }

        return result;
    }
}
// @lc code=end

