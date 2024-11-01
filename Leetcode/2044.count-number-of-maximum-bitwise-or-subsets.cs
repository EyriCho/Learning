/*
 * @lc app=leetcode id=2044 lang=csharp
 *
 * [2044] Count Number of Maximum Bitwise-OR Subsets
 */

// @lc code=start
public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        Dictionary<int, int> dict = new ();
        int max = 0;

        void Dfs(int current, int index)
        {
            int next = 0,
                count = 0;
            for (int i = index; i < nums.Length; i++)
            {
                next = current | nums[i];
                dict.TryGetValue(next, out count);
                dict[next] = count + 1;
                max = Math.Max(next, max);
                Dfs(next, i + 1);
            }
        }

        Dfs(0, 0);

        return dict[max];
    }
}
// @lc code=end

