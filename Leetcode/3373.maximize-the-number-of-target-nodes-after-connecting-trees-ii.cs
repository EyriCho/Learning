/*
 * @lc app=leetcode id=3373 lang=csharp
 *
 * [3373] Maximize the Number of Target Nodes After Connecting Trees II
 */

// @lc code=start
public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2) {
        int[] ColorNode(int[][] edges)
        {
            List<int>[] map = new List<int>[edges.Length + 1];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = new ();
            }

            foreach (int[] edge in edges)
            {
                map[edge[0]].Add(edge[1]);
                map[edge[1]].Add(edge[0]);
            }

            Queue<(int, int, int)> queue = new ();
            queue.Enqueue((-1, 0, 0));
            int[] result = new int[map.Length];
            int prev = 0, node = 0, odd = 0;
            while (queue.Count > 0)
            {
                (prev, node, odd) = queue.Dequeue();
                result[node] = odd;

                foreach (int next in map[node])
                {
                    if (next == prev)
                    {
                        continue;
                    }

                    queue.Enqueue((node, next, 1 - odd));
                }
            }

            return result;
        }

        int[] color1 = ColorNode(edges1),
            color2 = ColorNode(edges2);

        int odd2 = 0;
        foreach (int c in color2)
        {
            odd2 += c;
        }
        int max2 = Math.Max(odd2, color2.Length - odd2);
        int odd1 = 0;
        foreach (int c in color1)
        {
            odd1 += c;
        }

        int even1 = color1.Length - odd1 + max2;
        odd1 += max2;
        int[] result = new int[color1.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = color1[i] == 0 ? even1 : odd1;
        }
        
        return result;
    }
}
// @lc code=end

