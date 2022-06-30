/*
 * @lc app=leetcode id=743 lang=csharp
 *
 * [743] Network Delay Time
 */

// @lc code=start
public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var dict = new Dictionary<int, List<(int, int)>>();
        
        foreach (var time in times)
        {
            if (!dict.TryGetValue(time[0], out List<(int, int)> next))
            {
                dict[time[0]] = next = new List<(int, int)>();
            }
            
            next.Add((time[1], time[2]));
        }
        
        var reaches = new int[n + 1];
        Array.Fill(reaches, int.MaxValue);
        reaches[k] = 0;
        var queue = new Queue<(int, int)>();
        queue.Enqueue((k, 0));
        
        while (queue.Count > 0)
        {
            var (node, time) = queue.Dequeue();
            
            if (time > reaches[node])
            {
                continue;
            }
            
            if (dict.TryGetValue(node, out List<(int, int)> nexts))
            {
                foreach (var (next, travel) in nexts)
                {
                    if (reaches[next] > time + travel)
                    {
                        reaches[next] = time + travel;
                        queue.Enqueue((next, reaches[next]));
                    }
                }
            }
        }
        
        var result = 0;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Max(result, reaches[i]);
        }
        
        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

