/*
 * @lc app=leetcode id=1192 lang=csharp
 *
 * [1192] Critical Connections in a Network
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        var map = new IList<int>[n];
        var entry = new int[n];
        var low = new int[n];
        for (int i = 0; i < n; i++)
        {
            entry[i] = -1;
            low[i] = -1;
            map[i] = new List<int>();
        }
        for (int i = 0; i < connections.Count; i++)
        {
            map[connections[i][0]].Add(connections[i][1]);
            map[connections[i][1]].Add(connections[i][0]);
        }
        
        int time = 0;
        var result = new List<IList<int>>();
        
        void dfs(int node, int parent)
        {
            entry[node] = low[node] = time++;
            
            foreach (var next in map[node])
            {
                if (next == parent)
                    continue;
                if (entry[next] == -1)
                {
                    dfs(next, node);
                    low[node] = Math.Min(low[node], low[next]);
                    if (low[next] > entry[node])
                        result.Add(new int[] { node, next });
                }
                else
                    low[node] = Math.Min(low[node], entry[next]);
            }
        }
        
        dfs(0, -1);
        
        return result;
    }
}
// @lc code=end

