/*
 * @lc app=leetcode id=3372 lang=csharp
 *
 * [3372] Maximize the Number of Target Nodes After Connecting Trees I
 */

// @lc code=start
public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k) {
        List<int>[] BuildMap(int[][] edges)
        {
            List<int>[] rst = new List<int>[edges.Length + 1];
            for (int i = 0; i <= edges.Length; i++)
            {
                rst[i] = new ();
            }

            foreach (int[] edge in edges)
            {
                rst[edge[0]].Add(edge[1]);
                rst[edge[1]].Add(edge[0]);
            }

            return rst;
        }

        int Dfs(List<int>[] map, int parent, int node, int level)
        {
            int rst = 1;
            if (level == 0)
            {
                return rst;
            }
            foreach (int child in map[node])
            {
                if (child != parent)
                {
                    rst += Dfs(map, node, child, level - 1);
                }
            }
            return rst;
        }

        List<int>[] map1 = BuildMap(edges1),
            map2 = BuildMap(edges2);
        
        int max2 = 0;
        if (k > 0)
        {
            for (int i = 0; i < map2.Length; i++)
            {
                max2 = Math.Max(max2, Dfs(map2, -1, i, k - 1));
            }
        }

        int[] result = new int[map1.Length];
        for (int i= 0; i < map1.Length; i++)
        {
            result[i] = Dfs(map1, -1, i, k) + max2;
        }

        return result;
    }
}
// @lc code=end

