/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict = new ();

        int count = 0;
        foreach (int num in nums1)
        {
            count = 0;
            dict.TryGetValue(num, out count);
            dict[num] = count + 1;
        }

        List<int> list = new (nums1.Length);
        foreach (int num in nums2)
        {
            if (dict.ContainsKey(num) &&
                dict[num] > 0)
            {
                list.Add(num);
                dict[num]--;
            }
        }

        return list.ToArray();
    }
}
// @lc code=end

