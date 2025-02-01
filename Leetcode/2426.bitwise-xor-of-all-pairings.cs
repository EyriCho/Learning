/*
 * @lc app=leetcode id=2425 lang=csharp
 *
 * [2425] Bitwise XOR of All Pairings
 */

// @lc code=start
public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int result = 0;
        if (nums2.Length % 2 == 1)
        {
            foreach (int num in nums1)
            {
                result ^= num;
            }
        }

        if (nums1.Length % 2 == 1)
        {
            foreach (int num in nums2)
            {
                result ^= num;
            }
        }

        return result;
    }
}
// @lc code=end

