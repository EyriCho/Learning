/*
 * @lc app=leetcode id=2918 lang=csharp
 *
 * [2918] Minimum Equal Sum of Two Arrays After Replacing Zeros
 */

// @lc code=start
public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long sum1 = 0L, sum2 = 0L;
        int zero1 = 0, zero2 = 0;
        foreach (int num in nums1)
        {
            sum1 += num;
            if (num == 0)
            {
                zero1++;
                sum1++;
            }
        }

        foreach (int num in nums2)
        {
            sum2 += num;
            if (num == 0)
            {
                zero2++;
                sum2++;
            }
        }

        if ((zero1 == 0 && sum2 > sum1) || (zero2 == 0 && sum1 > sum2))
        {
            return -1;
        }

        return Math.Max(sum1, sum2);
    }
}
// @lc code=end

