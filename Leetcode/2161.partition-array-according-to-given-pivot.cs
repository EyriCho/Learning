/*
 * @lc app=leetcode id=2161 lang=csharp
 *
 * [2161] Partition Array According to Given Pivot
 */

// @lc code=start
public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int[] result = new int[nums.Length];
        int ri = 0,
            rr = result.Length - 1,
            i = 0,
            r = nums.Length - 1;

        for (; i < nums.Length; i++, r--)
        {
            if (nums[i] < pivot)
            {
                result[ri++] = nums[i];
            }
            if (nums[r] > pivot)
            {
                result[rr--] = nums[r];
            }
        }

        while (ri <= rr)
        {
            result[ri++] = pivot;
        }

        return result;
    }
}
// @lc code=end

