/*
 * @lc app=leetcode id=786 lang=csharp
 *
 * [786] K-th Smallest Prime Fraction
 */

// @lc code=start
public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        double l = 0D,
            r = 1D,
            mid = 0D;
        int p = 0,
            q = 0,
            count = 0;
        
        while (true)
        {
            mid = (l + r) / 2D;
            p = count = 0;
            q = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                while (j < arr.Length && mid * arr[j] < arr[i])
                {
                    j++;
                }
                count += arr.Length - j;
                if (j < arr.Length &&
                    arr[i] * q > arr[j] * p)
                {
                    p = arr[i];
                    q = arr[j];
                }
            }

            if (count == k)
            {
                return new int[] { p, q };
            }
            else if (count < k)
            {
                l = mid;
            }
            else
            {
                r = mid;
            }
        }

        return new int[] { 0, 0 };
    }
}
// @lc code=end

