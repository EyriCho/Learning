/*
 * @lc app=leetcode id=2192 lang=csharp
 *
 * [2192] All Ancestors of a Node in a Directed Acyclic Graph
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> GetAncestors(int n, int[][] edges) {
        HashSet<int>[] ancestors = new HashSet<int>[n];
        IList<int>[] graph = new IList<int>[n];
        int[] degrees = new int[n];

        for (int i = 0; i < n; i++)
        {
            ancestors[i] = new HashSet<int>();
            graph[i] = new List<int>();
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            degrees[edge[1]]++;
        }

        Queue<int> queue = new ();
        HashSet<int> set = new ();
        for (int i = 0; i < n; i++)
        {
            if (degrees[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            foreach (int next in graph[node])
            {
                ancestors[next].UnionWith(ancestors[node]);
                ancestors[next].Add(node);
                degrees[next]--;
                if (degrees[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }

        List<IList<int>> result = new (n);
        for (int i = 0; i < n; i++)
        {
            List<int> list = new (ancestors[i]);
            list.Sort();
            result.Add(list);
        }

        return result;
    }
}
// @lc code=end

