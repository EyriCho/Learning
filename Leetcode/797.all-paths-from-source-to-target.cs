/*
 * @lc app=leetcode id=797 lang=csharp
 *
 * [797] All Paths From Source to Target
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        if (graph.Length == 0) return result;
        
        var list = new List<IList<int>>(graph.Length);
        var path = new List<int>();
        path.Add(0);
        dfs(graph, path, result, 0);
        
        return result;
    }
    
    private void dfs(int[][] graph, IList<int> path, List<IList<int>> result, int node)
    {
        if (node == graph.Length - 1)
        {
            result.Add(new List<int>(path));
            return;
        }
        foreach (var next in graph[node])
        {
            path.Add(next);
            dfs(graph, path, result, next);
            path.Remove(next);
        }
    }
}
// @lc code=end

