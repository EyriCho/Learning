/*
 * @lc app=leetcode id=1971 lang=csharp
 *
 * [1971] Find if Path Exists in Graph
 */

// @lc code=start
public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if (source == destination)
        {
            return true;
        }

        List<int>[] transits = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            transits[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            transits[edge[0]].Add(edge[1]);
            transits[edge[1]].Add(edge[0]);
        }

        int current = 0;
        HashSet<int> set = new ();
        set.Add(source);
        Queue<int> queue = new ();
        queue.Enqueue(source);
        while (queue.Count > 0)
        {
            current = queue.Dequeue();

            foreach (int next in transits[current])
            {
                if (set.Contains(next))
                {
                    continue;
                }
                if (next == destination)
                {
                    return true;
                }

                set.Add(next);
                queue.Enqueue(next);
            }
        }

        return false;
    }
}
// @lc code=end

