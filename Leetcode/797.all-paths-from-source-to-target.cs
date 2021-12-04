/*
 * @lc app=leetcode id=797 lang=csharp
 *
 * [797] All Paths From Source to Target
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        var target = graph.Length - 1;
        var visited = new bool[graph.Length];
        var path = new List<int>(graph.Length);
        
        void find(int i)
        {
            if (visited[i])
                return;
            
            path.Add(i);
            if (i == target)
            {
                result.Add(new List<int>(path));
                path.RemoveAt(path.Count - 1);
                return;
            }
            
            visited[i] = true;
            for (int j = 0; j < graph[i].Length; j++)
            {
                find (graph[i][j]);
            }
            visited[i] = false;
            
            path.RemoveAt(path.Count - 1);
        }
        
        find(0);
        
        return result;
    }
}
// @lc code=end

