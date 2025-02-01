/*
 * @lc app=leetcode id=1462 lang=csharp
 *
 * [1462] Course Schedule IV
 */

// @lc code=start
public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        List<int>[] maps = new List<int>[numCourses];
        bool[,] depends = new bool[numCourses, numCourses];
        for (int i = 0; i < numCourses; i++)
        {
            maps[i] = new ();
        }

        foreach (int[] pre in prerequisites)
        {
            maps[pre[0]].Add(pre[1]);
        }

        void Bfs(int c)
        {
            Queue<int> queue = new ();
            queue.Enqueue(c);
            bool[] visited = new bool[numCourses];
            visited[c] = true;

            int course = 0;
            while (queue.Count > 0)
            {
                course = queue.Dequeue();
                foreach (int next in maps[course])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        depends[c, next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        for (int i = 0; i < numCourses; i++)
        {
            Bfs(i);
        }

        List<bool> result = new (queries.Length);
        foreach (int[] q in queries)
        {
            result.Add(depends[q[0], q[1]]);
        }
        return result;
    }
}
// @lc code=end

