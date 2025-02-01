/*
 * @lc app=leetcode id=802 lang=csharp
 *
 * [802] Find Eventual Safe States
 */

// @lc code=start
public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        bool?[] terminal = new bool?[graph.Length];

        bool IsTerminal(int idx)
        {
            if (terminal[idx].HasValue)
            {
                return terminal[idx].Value;
            }

            terminal[idx] = false;
            foreach (int next in graph[idx])
            {
                if (!IsTerminal(next))
                {
                    return false;
                }
            }
            terminal[idx] = true;

            return true;
        }

        List<int> result = new ();
        for (int i = 0; i < graph.Length; i++)
        {
            if (IsTerminal(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
// @lc code=end

