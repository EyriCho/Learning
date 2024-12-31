/*
 * @lc app=leetcode id=3203 lang=csharp
 *
 * [3203] Find Minimum Diameter After Merging Two Trees
 */

// @lc code=start
public class Solution {
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2) {
        
        (int, int) Dfs(int[][] edges)
        {
            HashSet<int>[] maps = new HashSet<int>[edges.Length + 1];
            for (int i = 0; i <= edges.Length; i++)
            {
                maps[i] = new();
            }
            int[] degrees = new int[maps.Length];

            foreach (int[] edge in edges)
            {
                maps[edge[0]].Add(edge[1]);
                maps[edge[1]].Add(edge[0]);
                degrees[edge[0]]++;
                degrees[edge[1]]++;
            }

            Queue<int> queue = new ();
            for (int i = 0; i < maps.Length; i++)
            {
                if (degrees[i] == 1)
                {
                    queue.Enqueue(i);
                }
            }

            int[] depths = new int[maps.Length];
            bool[] seen = new bool[maps.Length];
            int node = 0,
                depth = 0,
                diameter = 0;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (seen[node])
                {
                    continue;
                }
                seen[node] = true;

                foreach (int p in maps[node])
                {
                    if (seen[p])
                    {
                        continue;
                    }
                    diameter = Math.Max(diameter, depths[p] + depths[node] + 1);
                    depths[p] = Math.Max(depths[p], depths[node] + 1);
                    depth = Math.Max(depths[p], depth);
                    degrees[p]--;
                    if (degrees[p] == 1)
                    {
                        queue.Enqueue(p);
                    }
                }
            }

            return (depth, diameter);
        }

        (int depth1, int diameter1) = Dfs(edges1);
        (int depth2, int diameter2) = Dfs(edges2);

        return Math.Max(depth1 + depth2 + 1, Math.Max(diameter1, diameter2));
    }
}
// @lc code=end

