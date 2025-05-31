/*
 * @lc app=leetcode id=2894 lang=csharp
 *
 * [2894] Divisible and Non-divisible Sums Difference
 */

// @lc code=start
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int result = n * (n + 1) / 2;
        int nums2 = m;
        while (nums2 <= n)
        {
            result -= nums2 * 2;
            nums2 += m;
        }

        return result;
    }
}
// @lc code=end

