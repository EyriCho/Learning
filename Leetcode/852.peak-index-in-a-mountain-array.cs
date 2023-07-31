/*
 * @lc app=leetcode id=852 lang=csharp
 *
 * [852] Peak Index in a Mountain Array
 */

// @lc code=start
public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int l = 0,
            r = arr.Length - 1,
            m = 0;

        while (l <= r)
        {
            m = (l + r) >> 1;
            if (arr[m] < arr[m + 1])
            {
                l = m + 1;

            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}
// @lc code=end

