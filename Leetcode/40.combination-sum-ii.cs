/*
 * @lc app=leetcode id=40 lang=csharp
 *
 * [40] Combination Sum II
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> result = new ();
        List<int> temp = new(candidates.Length);

        Array.Sort(candidates);

        void Dfs(int index, int left)
        {
            if (left == 0)
            {
                result.Add(new List<int>(temp));
                return;
            }

            if (index >= candidates.Length)
            {
                return;
            }

            if (candidates[index] > left)
            {
                return;
            }

            int next = index + 1;
            while (next < candidates.Length && candidates[index] == candidates[next])
            {
                next++;
            }

            Dfs(next, left);
            for (int i = index; i < next; i++)
            {
                temp.Add(candidates[i]);
                left -= candidates[i];
                Dfs(next, left);
            }

            for (int i = index; i < next; i++)
            {
                temp.RemoveAt(temp.Count - 1);
            }
        }

        Dfs(0, target);

        return result;
    }
}
// @lc code=end

