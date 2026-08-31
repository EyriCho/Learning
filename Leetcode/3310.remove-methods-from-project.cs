/*
 * @lc app=leetcode id=3310 lang=csharp
 *
 * [3310] Remove Methods From Project
 */

// @lc code=start
public class Solution {
    public IList<int> RemainingMethods(int n, int k, int[][] invocations) {
        List<int>[] childs = new List<int>[n];
        int[] inDegrees = new int[n];
        for (int i = 0; i < n; i++)
        {
            childs[i] = new ();
        }
        
        foreach (int[] invoc in invocations)
        {
            childs[invoc[0]].Add(invoc[1]);
            inDegrees[invoc[1]]++;
        }

        int curr = 0;
        bool[] suspicious = new bool[n];
        suspicious[k] = true;
        Queue<int> queue = new ();
        queue.Enqueue(k);
        while (queue.Count > 0)
        {
            curr = queue.Dequeue();

            foreach (int c in childs[curr])
            {
                inDegrees[c]--;
                if (suspicious[c])
                {
                    continue;
                }

                suspicious[c] = true;
                queue.Enqueue(c);
            }
        }

        List<int> remaining = new ();
        for (int i = 0; i < n; i++)
        {
            if (suspicious[i] && inDegrees[i] > 0)
            {
                return Enumerable.Range(0, n).ToList();
            }
            else if (!suspicious[i])
            {
                remaining.Add(i);
            }
        }

        return remaining;
    }
}
// @lc code=end

