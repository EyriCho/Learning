/*
 * @lc app=leetcode id=2493 lang=csharp
 *
 * [2493] Divide Nodes Into the Maximum Number of Groups
 */

// @lc code=start
public class Solution {
    public int MagnificentSets(int n, int[][] edges) {
        List<int>[] maps = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            maps[i] = new ();
        }
        foreach (int[] edge in edges)
        {
            maps[edge[0] - 1].Add(edge[1] - 1);
            maps[edge[1] - 1].Add(edge[0] - 1);
        }

        int result = 0,
            time = 0,
            maxDepth;
        int[] times = new int[n],
            colors = new int[n];
        List<int> nodes = new ();

        bool ColorNode(int node, int color)
        {
            colors[node] = color;
            nodes.Add(node);
            foreach (int next in maps[node])
            {
                if (colors[next] == color ||
                    colors[next] == 0 && !ColorNode(next, -color))
                {
                    return false;
                }
            }

            return true;
        }

        int Bfs(int node)
        {
            int depth = 0;
            times[node] = ++time;
            Queue<int> queue = new ();
            queue.Enqueue(node);
            int count = 0,
                current = 0;
            while (queue.Count > 0)
            {
                count = queue.Count;
                while (count-- > 0)
                {
                    current = queue.Dequeue();
                    foreach (int next in maps[current])
                    {
                        if (times[next] != time)
                        {
                            times[next] = time;
                            queue.Enqueue(next);
                        }
                    }
                }
                depth++;
            }
            return depth;
        }

        for (int i = 0; i < n; i++)
        {
            if (colors[i] != 0)
            {
                continue;
            }
            nodes.Clear();
            if (!ColorNode(i, 1))
            {
                return -1;
            }
            maxDepth = 0;
            foreach (int node in nodes)
            {
                maxDepth = Math.Max(maxDepth, Bfs(node));
            }
            result += maxDepth;
        }
        
        return result;
    }
}
// @lc code=end

