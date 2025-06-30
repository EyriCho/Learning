/*
 * @lc app=leetcode id=2040 lang=csharp
 *
 * [2040] Kth Smallest Product of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public long KthSmallestProduct(int[] nums1, int[] nums2, long k)
    {
        (int, int, int) Count(int[] nums)
        {
            int negative = 0,
                zero = 0,
                positive = 0;
            foreach (int num in nums)
            {
                if (num < 0)
                {
                    negative++;
                }
                else if (num == 0)
                {
                    zero++;
                }
                else
                {
                    positive++;
                }
            }
            return (negative, zero, positive);
        }
        (int neg1, int zero1, int pos1) = Count(nums1);
        (int neg2, int zero2, int pos2) = Count(nums2);

        long l = 0, m = 0, r = 0;
        long CountProduct(int[] array1, int[] array2, long target)
        {
            long count = 0;
            int i2 = array2.Length - 1;
            foreach (int num in array1)
            {
                while (i2 >= 0 && (long)num * array2[i2] > target)
                {
                    i2--;
                }

                count += i2 + 1;
            }
            return count;
        }

        int[] negative1 = nums1[0..neg1],
            positive1 = nums1[(neg1 + zero1)..],
            negative2 = nums2[0..neg2],
            positive2 = nums2[(neg2 + zero2)..];

        int neg = neg1 * pos2 + neg2 * pos1;
        if (neg >= k)
        {
            Array.Reverse(positive1);
            Array.Reverse(positive2);
            l = Math.Min((long)nums1[0] * nums2[^1], (long)nums1[^1] * nums2[0]);
            r = 0;
            while (l < r)
            {
                m = (l + r) >> 1;

                if (CountProduct(positive1, negative2, m) + CountProduct(positive2, negative1, m) < k)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return r;
        }
        k -= neg;

        int zero = zero1 * nums2.Length + zero2 * nums1.Length - zero1 * zero2;
        if (zero >= k)
        {
            return 0L;
        }
        k -= zero;

        l = 1L;
        r = Math.Max((long)nums1[0] * nums2[0], (long)nums1[^1] * nums2[^1]);
        Array.Reverse(negative1);
        Array.Reverse(negative2);
        while (l < r)
        {
            m = (l + r) >> 1;

            if (CountProduct(negative1, negative2, m) + CountProduct(positive1, positive2, m) < k)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }
        return r;
    }
}
// @lc code=end

