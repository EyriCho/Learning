/*
 * @lc app=leetcode id=3108 lang=csharp
 *
 * [3108] Minimum Cost Walk in Weighted Graph
 */

// @lc code=start
public class Solution {
    public int[] MinimumCost(int n, int[][] edges, int[][] query) {
        int[] groups = new int[n],
            costs = new int[n];
        for (int i = 0; i < n; i++)
        {
            groups[i] = i;
            costs[i] = -1;
        }

        int FindGroup(int vertice)
        {
            if (vertice == groups[vertice])
            {
                return vertice;
            }

            return groups[vertice] = FindGroup(groups[vertice]);
        }
        
        int uRoot = 0,
            vRoot = 0;
        foreach (int[] edge in edges)
        {
            uRoot = FindGroup(edge[0]);
            vRoot = FindGroup(edge[1]);

            costs[vRoot] &= edge[2];

            if (uRoot != vRoot)
            {
                costs[vRoot] &= costs[uRoot];
                groups[uRoot] = vRoot;
            }
        }

        int[] result = new int[query.Length];
        for (int i = 0; i < query.Length; i++)
        {
            if (query[i][0] == query[i][1])
            {
                result[i] = 0;
            }
            else
            {
                uRoot = FindGroup(query[i][0]);
                vRoot = FindGroup(query[i][1]);
                
                result[i] = uRoot != vRoot ? -1 : costs[vRoot];
            }
        }

        return result;
    }
}
// @lc code=end

