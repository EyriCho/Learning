/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var inDegrees = new int[numCourses];

        foreach (var p in prerequisites)
        {
            inDegrees[p[1]]++;
        }

        var courses = numCourses;
        var queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (inDegrees[i] == 0)
            {
                queue.Enqueue(i);
                courses--;
            }
        }

        while (queue.Count > 0)
        {
            var idx = queue.Dequeue();
            foreach (var p in prerequisites)
            {
                if (p[0] == idx)
                {
                    inDegrees[p[1]]--;
                    if (inDegrees[p[1]] == 0)
                    {
                        queue.Enqueue(p[1]);
                        courses--;
                    }
                }
            }
        }

        return courses == 0;
    }
}
// @lc code=end

