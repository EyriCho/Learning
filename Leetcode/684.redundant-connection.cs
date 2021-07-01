/*
 * @lc app=leetcode id=684 lang=csharp
 *
 * [684] Redundant Connection
 */

// @lc code=start
public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var idx = new int[edges.Length + 1];
        for (int i = 0; i <= edges.Length; i++)
            idx[i] = i;
        
        var result = edges[0];
        foreach (var edge in edges)
        {
            int ix0 = edge[0],
                ix1 = edge[1];
            while (ix0 != idx[ix0])
                ix0 = idx[ix0];
            while (ix1 != idx[ix1])
                ix1 = idx[ix1];
            if (ix1 != ix0)
            {
                int ix = Math.Min(ix0, ix1);
                idx[ix0] = idx[ix1] = ix;
            }
            else
                result = edge;
        }
        
        return result;
    }
}
// @lc code=end

