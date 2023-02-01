/*
 * @lc app=leetcode id=491 lang=csharp
 *
 * [491] Non-decreasing Subsequences
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var result = new List<IList<int>>();
        var path = new List<int>(15);

        void dfs(int index)
        {
            if (index == nums.Length)
            {
                return;
            }

            var set = new HashSet<int>();
            for (int i = index; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]) ||
                    (path.Count > 0 && path[path.Count - 1] > nums[i]))
                {
                    continue;
                }

                set.Add(nums[i]);
                path.Add(nums[i]);
                if (path.Count > 1)
                {
                    result.Add(new List<int>(path));
                }
                dfs(i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }

        dfs(0);
        return result;
    }
}
// @lc code=end

