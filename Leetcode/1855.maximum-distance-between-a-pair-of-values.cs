/*
 * @lc app=leetcode id=1855 lang=csharp
 *
 * [1855] Maximum Distance Between a Pair of Values
 */

// @lc code=start
public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int i1 = 0, i2 = 0,
            result = 0;
        
        while (i1 < nums1.Length && i2 < nums2.Length)
        {
            if (nums1[i1] <= nums2[i2])
            {
                result = Math.Max(result, i2 - i1);
                i2++;
            }
            else
            {
                i1++;
            }
        }

        return result;
    }
}
// @lc code=end

