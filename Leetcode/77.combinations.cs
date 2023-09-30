/*
 * @lc app=leetcode id=77 lang=csharp
 *
 * [77] Combinations
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        
        var temp = new List<int>(k + 1);
        void Dfs(int i, int left)
        {
            if (i > n)
            {
                return;
            }
            if (left > n - i + 1)
            {
                return;
            }

            temp.Add(i);
            if (left == 1)
            {
                result.Add(new List<int>(temp));
            }
            else
            {
                Dfs(i + 1, left - 1);
            }
            temp.RemoveAt(temp.Count - 1);

            Dfs(i + 1, left);
        }

        Dfs(1, k);
        return result;
    }
}
// @lc code=end

