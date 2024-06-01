/*
 * @lc app=leetcode id=310 lang=csharp
 *
 * [310] Minimum Height Trees
 */

// @lc code=start
public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        List<int> result = new ();
        if (n == 1)
        {
            result.Add(0);
            return result;
        }
        
        HashSet<int>[] graph = new HashSet<int>[n];
        Queue<int> queue = new();
        for (int i = 0; i < n; i++)
        {
            graph[i] = new HashSet<int>();
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        for (int i = 0; i < n; i++)
        {
            if (graph[i].Count == 1)
            {
                queue.Enqueue(i);
            }
        }
        
        int count = 0,
            current = 0;
        while (n > 2)
        {
            count = queue.Count;
            n -= count;
            while (count-- > 0)
            {
                current = queue.Dequeue();
                foreach (int node in graph[current])
                {
                    graph[node].Remove(current);
                    if (graph[node].Count == 1)
                    {
                        queue.Enqueue(node);
                    }
                }
            }
        }
        
        while (queue.Count > 0)
        {
            result.Add(queue.Dequeue());
        }
        
        return result;
    }
}
// @lc code=end

