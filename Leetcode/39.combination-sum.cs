/*
 * @lc app=leetcode id=39 lang=csharp
 *
 * [39] Combination Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var temp = new List<int>();
        
        void dfs(int index, int left)
        {
            if (left < 0)
            {
                return;
            }
            else if (left == 0)
            {
                result.Add(new List<int>(temp));
                return;
            }
            else
            {
                for (int i = index; i < candidates.Length; i++)
                {
                    temp.Add(candidates[i]);
                    dfs(i, left - candidates[i]);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
        
        dfs(0, target);
        return result;
    }
}
// @lc code=end

