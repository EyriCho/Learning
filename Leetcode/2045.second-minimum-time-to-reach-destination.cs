/*
 * @lc app=leetcode id=2045 lang=csharp
 *
 * [2045] Second Minimum Time to Reach Destination
 */

// @lc code=start
public class Solution {
    public int SecondMinimum(int n, int[][] edges, int time, int change) {
        List<int>[] maps = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            maps[i] = new List<int>();
        }
        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        int[,] travels = new int[n + 1, 2];
        for (int i = 1; i <= n; i++)
        {
            travels[i, 0] = travels[i, 1] = int.MaxValue;
        }

        Queue<(int, int)> queue = new ();
        queue.Enqueue((1, 0));
        int city = 0,
            travel = 0;
        while (queue.Count > 0)
        {
            (city, travel) = queue.Dequeue();
            travel++;
            foreach (int next in maps[city]) 
            {
                if (travel < travels[next, 0])
                {
                    travels[next, 1] = travels[next, 0];
                    travels[next, 0] = travel;
                    queue.Enqueue((next, travel));
                }
                else if (travel == travels[next, 0])
                {
                    continue;
                }
                else if (travel < travels[next, 1])
                {
                    travels[next, 1] = travel;
                    queue.Enqueue((next, travel));
                }
            }
        }

        int result = 0;
        for (int i = 0; i < travels[n, 1]; i++)
        {
            if ((result / change) % 2 == 1)
            {
                result = (result / change + 1) * change;
            }
            result += time;
        }
        return result;
    }
}
// @lc code=end

