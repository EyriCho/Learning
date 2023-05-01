/*
 * @lc app=leetcode id=1579 lang=csharp
 *
 * [1579] Remove Max Number of Edges to Keep Graph Fully Traversable
 */

// @lc code=start
public class Solution {
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        Array.Sort(edges, (a, b) => b[0] - a[0]);

        int Find(int[] g, int index)
        {
            if (g[index] != index)
            {
                return g[index] = Find(g, g[index]);
            }

            return index;
        }

        int[] alice = new int[n + 1],
            bob = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            alice[i] = i;
            bob[i] = i;
        }

        var count = 0;
        foreach (var edge in edges)
        {
            if (edge[0] == 3)
            {
                int u = Find(alice, edge[1]);
                int v = Find(alice, edge[2]);
                if (u != v)
                {
                    alice[u] = v;
                    Find(bob, edge[1]);
                    Find(bob, edge[2]);
                    bob[u] = v;
                }
                else
                {
                    count++;
                }
            }
            else if (edge[0] == 2)
            {
                int u = Find(bob, edge[1]);
                int v = Find(bob, edge[2]);
                if (u != v)
                {
                    bob[u] = v;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                int u = Find(alice, edge[1]);
                int v = Find(alice, edge[2]);
                if (u != v)
                {
                    alice[u] = v;
                }
                else
                {
                    count++;
                }
            }
        }

        var groups = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i == alice[i])
            {
                groups++;
            }
        }
        if (groups != 1)
        {
            return -1;
        }

        groups = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i == bob[i])
            {
                groups++;
            }
        }

        if (groups != 1)
        {
            return -1;
        }

        return count;
    }
}
// @lc code=end

