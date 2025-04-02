/*
 * @lc app=leetcode id=2570 lang=csharp
 *
 * [2570] Merge Two 2D Arrays by Summing Values
 */

// @lc code=start
public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        List<int[]> list = new ();

        int i1 = 0,
            i2 = 0;

        while (i1 < nums1.Length && i2 < nums2.Length)
        {
            if (nums1[i1][0] == nums2[i2][0])
            {
                list.Add(new int[] {
                    nums1[i1][0],
                    nums1[i1][1] + nums2[i2][1],
                });
                i1++;
                i2++;
            }
            else if (nums1[i1][0] < nums2[i2][0])
            {
                list.Add(nums1[i1++]);
            }
            else
            {
                list.Add(nums2[i2++]);
            }
        }

        while (i1 < nums1.Length)
        {
            list.Add(nums1[i1++]);
        }
        while (i2 < nums2.Length)
        {
            list.Add(nums2[i2++]);
        }

        return list.ToArray();
    }
}
// @lc code=end

