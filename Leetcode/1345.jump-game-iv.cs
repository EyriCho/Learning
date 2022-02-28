/*
 * @lc app=leetcode id=1345 lang=csharp
 *
 * [1345] Jump Game IV
 */

// @lc code=start
public class Solution {
    public int MinJumps(int[] arr) {
        if (arr.Length < 3)
            return arr.Length - 1;
        
        var dict = new Dictionary<int, IList<int>>();
        var visited = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
                dict[arr[i]] = new List<int>();
            dict[arr[i]].Add(i);
            visited[i] = int.MaxValue;
        }
        
        var queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        while (queue.Count > 0)
        {
            var (index, pace) = queue.Dequeue();
            if (index == arr.Length - 1)
                return pace;
            
            var nextPace = pace + 1;

            if (index > 0 && visited[index - 1] > nextPace)
            {
                queue.Enqueue((index - 1, nextPace));
                visited[index - 1] = nextPace;
            }

            if (visited[index + 1] > nextPace)
            {
                queue.Enqueue((index + 1, nextPace));
                visited[index + 1] = nextPace;
            }

            foreach (var next in dict[arr[index]])
            {
                if (next == index)
                    continue;
                
                if (visited[next] >= nextPace)
                {
                    queue.Enqueue((next, nextPace));
                    visited[next] = nextPace;
                }
                else
                    break;
            }
        }
        
        return 0;
    }
}
// @lc code=end

