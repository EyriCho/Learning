/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var list = new List<int>(nums1.Length);
        var dict = new Dictionary<int, int>();
        foreach (var num in nums1)
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        
        foreach (var num in nums2)
            if (dict.ContainsKey(num) && dict[num] > 0)
            {
                dict[num]--;
                list.Add(num);
            }
        
        return list.ToArray();
    }
}
// @lc code=end

