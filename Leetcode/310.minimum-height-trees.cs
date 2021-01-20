/*
 * @lc app=leetcode id=310 lang=csharp
 *
 * [310] Minimum Height Trees
 */

// @lc code=start
public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        if (n < 2)
            return new List<int> { 0 };
        var result = new List<int>();
        var graph = new IList<int>[n];
        var queue = new Queue<int>();
        for (int i = 0; i < n; i++)
            graph[i] = new List<int>();
        
        for (int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);
        }
        
        for (int i = 0; i < n; i++)
            if (graph[i].Count == 1)
                queue.Enqueue(i);
        
        while (n > 2)
        {
            int size = queue.Count;
            n -= size;
            while (size > 0)
            {
                var cur = queue.Dequeue();
                foreach (var next in graph[cur])
                {
                    graph[next].Remove(cur);
                    if (graph[next].Count == 1)
                        queue.Enqueue(next);
                }
                --size;
            }
        }
        
        while (queue.Count > 0)
            result.Add(queue.Dequeue());
        
        return result;
    }
}
// @lc code=end

