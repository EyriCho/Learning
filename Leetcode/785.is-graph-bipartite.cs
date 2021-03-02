/*
 * @lc app=leetcode id=785 lang=csharp
 *
 * [785] Is Graph Bipartite?
 */

// @lc code=start
public class Solution {
    public bool IsBipartite(int[][] graph) {
        int[] visited = new int[graph.Length];
        
        var stack = new Stack<(int, bool)>();
        
        for (int i = 0; i < graph.Length; i++)
            stack.Push((i, true));
        
        while (stack.Count > 0)
        {
            var (n, isA) = stack.Pop();
            if (visited[n] != 0)
                continue;
            
            visited[n] = isA ? 1 : -1;
            
            foreach (var ln in graph[n])
            {
                if (visited[ln] != 0)
                {
                    if (visited[ln] != -visited[n])
                        return false;
                }
                else
                {
                    stack.Push((ln, !isA));
                }
            }
        }
        
        return true;
    }
}
// @lc code=end

