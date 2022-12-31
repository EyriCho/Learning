/*
 * @lc app=leetcode id=797 lang=csharp
 *
 * [797] All Paths From Source to Target
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        var path = new List<int>();

        void Dfs(int i)
        {
            if (i == graph.Length - 1)
            {
                var list = new List<int>(path);
                list.Add(i);
                result.Add(list);
                return;
            }

            path.Add(i);
            foreach (var n in graph[i])
            {
                Dfs(n);
            }
            path.RemoveAt(path.Count - 1);
        }

        Dfs(0);

        return result;
    }
}
// @lc code=end

