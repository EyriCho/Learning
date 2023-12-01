/*
 * @lc app=leetcode id=815 lang=csharp
 *
 * [815] Bus Routes
 */

// @lc code=start
public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source == target)
        {
            return 0;
        }
        Dictionary<int, IList<int>> stops = new ();

        for (int i = 0; i < routes.Length; i++)
        {
            foreach (int s in routes[i])
            {
                if (!stops.TryGetValue(s, out IList<int> list))
                {
                    stops[s] = list = new List<int>();
                }

                stops[s].Add(i);
            }
        }

        HashSet<int> busTaken = new();
        HashSet<int> arrived = new();
        Queue<int> queue = new();
        queue.Enqueue(source);
        arrived.Add(source);
        int result = 0;

        while (queue.Count > 0)
        {
            int count = queue.Count;
            while (count-- > 0)
            {
                int stop = queue.Dequeue();
                if (stop == target)
                {
                    return result;
                }

                if (!stops.ContainsKey(stop))
                {
                    continue;
                }

                foreach (int bus in stops[stop])
                {
                    if (busTaken.Contains(bus))
                    {
                        continue;
                    }
                    busTaken.Add(bus);
                    
                    foreach (int next in routes[bus])
                    {
                        if (arrived.Contains(next))
                        {
                            continue;
                        }

                        arrived.Add(next);
                        queue.Enqueue(next);
                    }
                }
            }

            result++;
        }

        return -1;
    }
}
// @lc code=end

