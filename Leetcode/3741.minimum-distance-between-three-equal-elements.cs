/*
 * @lc app=leetcode id=3741 lang=csharp
 *
 * [3741] Minimum Distance Between Three Equal Elements II
 */

// @lc code=start
public class Solution {
    public int MinimumDistance(int[] nums) {
        int result = int.MaxValue;
        Dictionary<int, IList<int>> dict = new ();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out IList<int> list))
            {
                dict[nums[i]] = list = new List<int>();
            }
            if (list.Count > 1)
            {
                result = Math.Min(result, (i - list[^2]) << 1);
            }
            list.Add(i);
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

