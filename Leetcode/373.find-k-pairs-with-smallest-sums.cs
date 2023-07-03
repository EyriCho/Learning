/*
 * @lc app=leetcode id=373 lang=csharp
 *
 * [373] Find K Pairs with Smallest Sums
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var len = Math.Min(nums1.Length, k);

        PriorityQueue<(int, int), int> queue = new (len);
        for (int i1 = 0; i1 < len; i1++)
        {
            queue.Enqueue((i1, 0), nums1[i1] + nums2[0]);
        }

        var result = new List<IList<int>>();
        while (queue.Count > 0 && k-- > 0)
        {
            var (i1, i2) = queue.Dequeue();

            result.Add(new List<int> { nums1[i1], nums2[i2] });

            if (i2 < nums2.Length - 1)
            {
                queue.Enqueue((i1, i2 + 1), nums1[i1] + nums2[i2 + 1]);
            }
        }

        return result;
    }
}
// @lc code=end

