/*
 * @lc app=leetcode id=2179 lang=csharp
 *
 * [2179] Count Good Triplets in an Array
 */

// @lc code=start
public class Solution {
    public long GoodTriplets(int[] nums1, int[] nums2) {
        int[] bit = new int[nums1.Length + 2];

        int Query(int idx)
        {
            int rst = 0;
            while (idx > 0)
            {
                rst += bit[idx];
                idx -= (idx & -idx);
            }
            return rst;
        }

        void Update(int idx)
        {
            while (idx < bit.Length)
            {
                bit[idx] += 1;
                idx += (idx & -idx);
            }
        }

        int[] idxs = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            idxs[nums2[i]] = i;
        }
        
        long result = 0;
        int idx = 0,
            l = 0,
            r = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            idx = idxs[nums1[i]];
            l = Query(idx + 1);
            r = nums1.Length - idx - 1 - (i - l);
            result += (long)l * r;
            Update(idx + 1);
        }        

        return result;
    }
}
// @lc code=end

