/*
 * @lc app=leetcode id=834 lang=csharp
 *
 * [834] Sum of Distances in Tree
 */

// @lc code=start
public class Solution {
    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        int[] result = new int[n],
            count = new int[n];

        HashSet<int>[] map = new HashSet<int>[n];
        for (int i = 0; i < n; i++)
        {
            map[i] = new HashSet<int>();
        }

        foreach (var edge in edges)
        {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }

        void Travel(int cur, int prev)
        {
            foreach (int next in map[cur])
            {
                if (next == prev)
                {
                    continue;
                }
                Travel(next, cur);
                count[cur] += count[next];
                result[cur] += result[next] + count[next];
            }
            count[cur]++;
        }

        void Sum(int cur, int prev)
        {
            foreach (int next in map[cur])
            {
                if (prev == next)
                {
                    continue;
                }
                result[next] = result[cur] + (n - count[next]) - count[next]; 
                Sum(next, cur);
            }
        }

        Travel(0, -1);
        Sum(0, -1);
        return result;
    }
}
// @lc code=end

