/*
 * @lc app=leetcode id=684 lang=csharp
 *
 * [684] Redundant Connection
 */

// @lc code=start
public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int[] group = new int[edges.Length + 1];
        for (int i = 1; i <= edges.Length; i++)
        {
            group[i] = i;
        }

        int FindGroup(int node)
        {
            if (group[node] != node)
            {
                return group[node] = FindGroup(group[node]);
            }

            return node;
        }

        int a = 0, b = 0;
        foreach (int[] edge in edges)
        {
            a = FindGroup(edge[0]);
            b = FindGroup(edge[1]);
            if (a == b)
            {
                return edge;
            }

            group[a] = b;
        }

        return null;
    }
}
// @lc code=end

