/*
 * @lc app=leetcode id=1306 lang=csharp
 *
 * [1306] Jump Game III
 */

// @lc code=start
public class Solution {
    public bool CanReach(int[] arr, int start) {
        Queue<int> queue = new ();
        bool[] visited = new bool[arr.Length];
        queue.Enqueue(start);
        visited[start] = true;

        int current = 0,
            next = 0;
        while (queue.Count > 0)
        {
            current = queue.Dequeue();
            if (arr[current] == 0)
            {
                return true;
            }

            next = current - arr[current];
            if (next >= 0 && !visited[next])
            {
                queue.Enqueue(next);
                visited[next] = true;
            }

            next = current + arr[current];
            if (next < arr.Length && !visited[next])
            {
                queue.Enqueue(next);
                visited[next] = true;
            }
        }

        return false;
    }
}
// @lc code=end

