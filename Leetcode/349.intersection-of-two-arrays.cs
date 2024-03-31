/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */

// @lc code=start
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new (nums1);
        HashSet<int> set2 = new ();
        foreach (int num in nums2)
        {
            if (set1.Contains(num))
            {
                set2.Add(num);
            }
        }

        return set2.ToArray();
    }
}
// @lc code=end

