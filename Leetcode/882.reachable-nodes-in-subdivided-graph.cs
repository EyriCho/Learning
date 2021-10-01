/*
 * @lc app=leetcode id=882 lang=csharp
 *
 * [882] Reachable Nodes In Subdivided Graph
 */

// @lc code=start
public class Solution {
    public int ReachableNodes(int[][] edges, int maxMoves, int n) {
        var graph = new int[n, n];
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                graph[i, j] = -1;
        
        foreach (var edge in edges)
        {
            graph[edge[0], edge[1]] = edge[2];            
            graph[edge[1], edge[0]] = edge[2];            
        }
                
        var stack = new (int, int)[10_000];
        int length = 0;
        void Add(int leftMove, int index)
        {
            int i = length;
            stack[length++] = (leftMove, index);
            
            while (i > 0)
            {
                var p = (i - 1) / 2;
                if (stack[p].Item1 >= stack[i].Item1)
                    return;
                var temp = stack[p];
                stack[p] = stack[i];
                stack[i] = temp;
                i = p;
            }
        }
        
        (int, int) Pop()
        {
            var result = stack[0];
            stack[0] = stack[--length];
            var i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
                if (stack[i].Item1 < stack[l].Item1 ||
                   (r < length && stack[i].Item1 < stack[r].Item1))
                {
                    if (r >= length || stack[l].Item1 >= stack[r].Item1)
                    {
                        var temp = stack[i];
                        stack[i] = stack[l];
                        stack[l] = temp;
                        i = l;
                    }
                    else
                    {
                        var temp = stack[i];
                        stack[i] = stack[r];
                        stack[r] = temp;
                        i = r;
                    }
                }
                else
                    break;
            }
            return result;
        }
        
        Add(maxMoves, 0);
        
        var result = 0;
        var visit = new bool[n];
        while (length > 0)
        {
            (int left, int i) = Pop();
            if (visit[i])
                continue;
            visit[i] = true;
            result++;
            
            for (int j = 0; j < n; j++)
            {
                if (graph[i, j] < 0)
                    continue;
                                
                if (left > graph[i, j] && !visit[j])
                    Add(left - graph[i, j] - 1, j);
                graph[j, i] -= Math.Min(left, graph[i, j]);
                result += Math.Min(left, graph[i, j]);
            }
        }
                
        return result;
    }
}
// @lc code=end

