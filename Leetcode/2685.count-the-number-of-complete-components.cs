/*
 * @lc app=leetcode id=2685 lang=csharp
 *
 * [2685] Count the Number of Complete Components
 */

// @lc code=start
public class Solution {
    public int CountCompleteComponents(int n, int[][] edges) {
        int[] groups = new int[n],
            counts = new int[n],
            edgeCounts = new int[n];

        for (int i = 0; i < n; i++)
        {
            groups[i] = i;
            counts[i] = 1;
        }

        int FindGroup(int v)
        {
            if (v != groups[v])
            {
                return groups[v] = FindGroup(groups[v]);
            }

            return v;
        }

        int aGroup = 0,
            bGroup = 0;
        foreach (int[] edge in edges)
        {
            aGroup = FindGroup(edge[0]);
            bGroup = FindGroup(edge[1]);

            if (aGroup == bGroup)
            {
                edgeCounts[aGroup]++;
                continue;
            }

            groups[bGroup] = aGroup;
            counts[aGroup] += counts[bGroup];
            edgeCounts[aGroup] += edgeCounts[bGroup] + 1;
        }

        int result = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == groups[i] &&
                counts[i] * (counts[i] - 1) / 2 == edgeCounts[i])
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

