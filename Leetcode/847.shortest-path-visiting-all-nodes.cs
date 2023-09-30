/*
 * @lc app=leetcode id=847 lang=csharp
 *
 * [847] Shortest Path Visiting All Nodes
 */

// @lc code=start
public class Solution {
    public int ShortestPathLength(int[][] graph) {
        int result = 0,
            target = (1 << graph.Length) - 1;
        var queue = new Queue<(int, int)>();
        var visited = new bool[target, graph.Length];
        for (int i = 0; i < graph.Length; i++)
        {
            var state = 1 << i;
            queue.Enqueue((state, i));
        }
        
        while (queue.Count > 0)
        {
            var count = queue.Count;
            while (count-- > 0)
            {
                var (state, i) = queue.Dequeue();
                if (state == target)
                {
                    return result;
                }
                if (visited[state, i])
                {
                    continue;
                }
                visited[state, i] = true;
                foreach (var next in graph[i])
                {
                    queue.Enqueue((state | (1 << next), next));
                }
            }
            result++;
        }
        
        return int.MinValue;
    }
}
// @lc code=end

