/*
 * @lc app=leetcode id=1345 lang=csharp
 *
 * [1345] Jump Game IV
 */

// @lc code=start
public class Solution {
    public int MinJumps(int[] arr) {
        int[] visited = new int[arr.Length];
        Dictionary<int, IList<int>> dict = new ();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.TryGetValue(arr[i], out IList<int> list))
            {
                dict[arr[i]] = list = new List<int> ();
            }
            list.Insert(0, i);
            visited[i] = int.MaxValue;
        }
        visited[0] = 0;

        Queue<(int, int)> queue = new ();
        queue.Enqueue((0, 0));
        int current = 0,
            step = 0,
            next = 0;
        while (queue.Count > 0)
        {
            (current, step) = queue.Dequeue();
            if (current == arr.Length - 1)
            {
                return step;
            }

            step++;
            next = current - 1;
            if (next >= 0 &&
                visited[next] > step)
            {
                queue.Enqueue((next, step));
                visited[next] = step;
            }

            next = current + 1;
            if (next < arr.Length &&
                visited[next] > step)
            {
                queue.Enqueue((next, step));
                visited[next] = step;
            }

            foreach (int n in dict[arr[current]])
            {
                if (n == current)
                {
                    continue;
                }

                if (visited[n] < step)
                {
                    break;
                }

                queue.Enqueue((n, step));
                visited[n] = step;
            }
        }

        return arr.Length - 1;
    }
}
// @lc code=end

