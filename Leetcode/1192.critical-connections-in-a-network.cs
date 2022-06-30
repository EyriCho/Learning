/*
 * @lc app=leetcode id=1192 lang=csharp
 *
 * [1192] Critical Connections in a Network
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        var map = new List<int>[n];
        int[] low = new int[n],
            entry = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            low[i] = entry[i] = -1;
            map[i] = new List<int>();
        }
        
        foreach (var connection in connections)
        {
            map[connection[0]].Add(connection[1]);
            map[connection[1]].Add(connection[0]);
        }
        
        var order = 0;
        var result = new List<IList<int>>();
        
        void dfs(int curr, int prev)
        {
            entry[curr] = low[curr] = order++;
            
            foreach (var next in map[curr])
            {
                if (next == prev)
                {
                    continue;
                }
                
                if (entry[next] == -1)
                {
                    dfs(next, curr);
                    low[curr] = Math.Min(low[curr], low[next]);
                    
                    if (low[next] > entry[curr])
                    {
                        result.Add(new List<int> { curr, next });
                    }
                }
                else
                {
                    low[curr] = Math.Min(low[curr], entry[next]);
                }
            }
        }
        
        dfs(0, -1);
        
        return result;
    }
}
// @lc code=end

