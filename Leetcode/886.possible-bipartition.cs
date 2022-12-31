/*
 * @lc app=leetcode id=886 lang=csharp
 *
 * [886] Possible Bipartition
 */

// @lc code=start
public class Solution {
    public bool PossibleBipartition(int n, int[][] dislikes) {
        var group = new int[n + 1];
        var graph = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var dislike in dislikes)
        {
            graph[dislike[0]].Add(dislike[1]);
            graph[dislike[1]].Add(dislike[0]);
        }

        var queue = new Queue<int>();
        for (int i = 1; i <= n; i++)
        {
            if (group[i] == 0)
            {
                group[i] = 1;
                queue.Enqueue(i);
            }

            while (queue.Count > 0)
            {
                var c = queue.Dequeue();

                foreach (var dislike in graph[c])
                {
                    if (group[dislike] == 0)
                    {
                        group[dislike] = - group[c];
                        queue.Enqueue(dislike);
                    }
                    else if (group[dislike] == group[c])
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
// @lc code=end

