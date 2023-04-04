/*
 * @lc app=leetcode id=1466 lang=csharp
 *
 * [1466] Reorder Routes to Make All Paths Lead to the City Zero
 */

// @lc code=start
public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var directRoute = new List<int>[n];
        var reverseRoute = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            directRoute[i] = new List<int>();
            reverseRoute[i] = new List<int>();
        }

        foreach (var connection in connections)
        {
            directRoute[connection[0]].Add(connection[1]);
            reverseRoute[connection[1]].Add(connection[0]);
        }

        var result = 0;
        var isReachable = new bool[n];
        isReachable[0] = true;
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while (queue.Count > 0)
        {
            var city = queue.Dequeue();

            foreach (var prev in reverseRoute[city])
            {
                if (!isReachable[prev])
                {
                    isReachable[prev] = true;
                    queue.Enqueue(prev);
                }
            }

            foreach (var next in directRoute[city])
            {
                if (!isReachable[next])
                {
                    result++;
                    isReachable[next] = true;
                    queue.Enqueue(next);
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

