/*
 * @lc app=leetcode id=2071 lang=csharp
 *
 * [2071] Maximum Number of Tasks You Can Assign
 */

// @lc code=start
public class Solution {
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength) {
        Array.Sort(tasks);
        Array.Sort(workers);

        bool CanAssign(int k)
        {
            int pillUsed = 0,
                w = workers.Length - 1;
            
            LinkedList<int> list = new ();
            for (int t = k - 1; t >= 0; t--)
            {
                while (w >= workers.Length - k &&  tasks[t] - workers[w] <= strength)
                {
                    list.AddFirst(workers[w]);
                    w--;
                }

                if (list.Count == 0)
                {
                    return false;
                }

                if (list.Last.Value >= tasks[t])
                {
                    list.RemoveLast();
                }
                else
                {
                    if (pillUsed == pills)
                    {
                        return false;
                    }

                    list.RemoveFirst();
                    pillUsed++;
                }
            }

            return true;
        }

        int l = 0,
            r = Math.Min(tasks.Length, workers.Length),
            m = 0,
            result = 0;

        while (l <= r)
        {
            m = (l + r) >> 1;
            if (CanAssign(m))
            {
                result = m;
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return result;
    }
}
// @lc code=end

