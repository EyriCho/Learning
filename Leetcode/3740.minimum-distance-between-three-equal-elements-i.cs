/*
 * @lc app=leetcode id=3740 lang=csharp
 *
 * [3740] Minimum Distance Between Three Equal Elements I
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
            list.Add(i);
            if (list.Count >= 3)
            {
                result = Math.Min(result,
                    (i - list[^3]) << 1);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

