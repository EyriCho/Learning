/*
 * @lc app=leetcode id=2597 lang=csharp
 *
 * [2597] The Number of Beautiful Subsets
 */

// @lc code=start
public class Solution {
    public int BeautifulSubsets(int[] nums, int k) {
        int result = 0;
        Dictionary<int, int> dict = new ();

        void Dfs(int index)
        {
            result++;

            for (int i = index; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i] - k) ||
                    dict.ContainsKey(nums[i] + k))
                {
                    continue;
                }

                dict.TryGetValue(nums[i], out int count);
                dict[nums[i]] = count + 1;
                Dfs(i + 1);
                if (count == 0)
                {
                    dict.Remove(nums[i]);
                }
                else
                {
                    dict[nums[i]] = count;
                }
            }
        }

        Dfs(0);

        return result - 1;
   }
}
// @lc code=end

