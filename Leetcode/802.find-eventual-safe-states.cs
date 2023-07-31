/*
 * @lc app=leetcode id=802 lang=csharp
 *
 * [802] Find Eventual Safe States
 */

// @lc code=start
public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var isLoop = new bool?[graph.Length];
        var set = new HashSet<int>();

        bool CheckLoop(int idx)
        {
            if (isLoop[idx].HasValue)
            {
                return isLoop[idx].Value;
            }
            set.Add(idx);

            isLoop[idx] = false;
            foreach (var next in graph[idx])
            {
                if (set.Contains(next)
                    || CheckLoop(next))
                {
                    isLoop[idx] = true;
                    break;
                }
            }
            set.Remove(idx);

            return isLoop[idx].Value;
        }

        var result = new List<int>();
        for (int i = 0; i < graph.Length; i++)
        {
            if (CheckLoop(i))
            {
                continue;
            }

            result.Add(i);
        }

        return result;
    }
}
// @lc code=end

