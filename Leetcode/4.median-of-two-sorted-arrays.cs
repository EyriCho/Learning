/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int total = nums1.Length + nums2.Length;
        int count = total / 2;
        
        int prev = 0, curr = 0;
        int i1 = 0, i2 = 0;
        while (count-- >= 0)
        {
            if (i1 >= nums1.Length)
            {
                prev = curr;
                curr = nums2[i2++];
            }
            else if (i2 >= nums2.Length)
            {
                prev = curr;
                curr = nums1[i1++];
            }
            else
            {
                if (nums1[i1] <= nums2[i2])
                {
                    prev = curr;
                    curr = nums1[i1++];
                }
                else
                {
                    prev = curr;
                    curr = nums2[i2++];                    
                }
            }
        }
                
        return total % 2 == 1 ? (double)curr : (prev + curr) / 2.0D;
    }
}
// @lc code=end

