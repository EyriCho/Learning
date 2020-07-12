/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        if (nums?.Any() != true) return result;

        nums = nums.Distinct().ToArray();
        var count = (int)Math.Pow(2, nums.Length);
        for (int i = 1; i < count; i++)
        {
            var list = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if ((i & (1 << j)) > 0)
                    list.Add(nums[j]);
            }
            result.Add(list);
        }
        return result;
    }
}
// @lc code=end

