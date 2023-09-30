/*
 * @lc app=leetcode id=1203 lang=csharp
 *
 * [1203] Sort Items by Groups Respecting Dependencies
 */

// @lc code=start
public class Solution {
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems) {
        int GetGroup(int node)
        {
            return group[node] == -1 ? node + 100_000 : group[node];
        }

        var dictGroup = new Dictionary<int, IList<int>>();
        var nextGroup = new Dictionary<int, (HashSet<int>, int)>();
        var next = new Dictionary<int, (HashSet<int>, int)>();
        for (int i = 0; i < n; i++)
        {
            var gi = GetGroup(i);
            if (!dictGroup.TryGetValue(gi, out IList<int> list))
            {
                dictGroup[gi] = list = new List<int>();
            }
            list.Add(i);

            foreach (var before in beforeItems[i])
            {
                var gb = GetGroup(before);
                if (gi == gb)
                {
                    if (!next.ContainsKey(before))
                    {
                        next[before] = (new HashSet<int>(), 0);
                    }

                    if (!next.ContainsKey(i))
                    {
                        next[i] = (new HashSet<int>(), 0);
                    }

                    next[before].Item1.Add(i);
                    next[i] = (next[i].Item1, next[i].Item2 + 1);
                }
                else
                {
                    if (!nextGroup.ContainsKey(gb))
                    {
                        nextGroup[gb] = (new HashSet<int>(), 0);
                    }
                    if (!nextGroup.ContainsKey(gi))
                    {
                        nextGroup[gi] = (new HashSet<int>(), 0);
                    }

                    if (!nextGroup[gb].Item1.Contains(gi))
                    {
                        nextGroup[gb].Item1.Add(gi);
                        nextGroup[gi] = (nextGroup[gi].Item1, nextGroup[gi].Item2 + 1);
                    }
                }
            }
        }

        int[] GetGroupItem(int g)
        {
            if (dictGroup[g].Count <= 1)
            {
                return dictGroup[g].ToArray();
            }
            var rst = new int[dictGroup[g].Count];
            int i = 0;
            
            var queue = new Queue<int>();
            foreach (int item in dictGroup[g])
            {
                if (!next.ContainsKey(item) || next[item].Item2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                rst[i++] = item;

                if (next.ContainsKey(item))
                {
                    foreach (var n in next[item].Item1)
                    {
                        if (next[n].Item2 == 1)
                        {
                            queue.Enqueue(n);
                        }
                        else
                        {
                            next[n] = (next[n].Item1, next[n].Item2 - 1);
                        }
                    }
                }
            }

            return i == dictGroup[g].Count ? rst : new int[0];
        }

        var result = new int[n];
        int idx =0;
        var queueGroup = new Queue<int>();
        foreach (var g in dictGroup.Keys)
        {
            if (!nextGroup.ContainsKey(g) || nextGroup[g].Item2 == 0)
            {
                queueGroup.Enqueue(g);
            }
        }

        while (queueGroup.Count > 0)
        {
            var g = queueGroup.Dequeue();
            var items = GetGroupItem(g);
            if (items.Length != dictGroup[g].Count)
            {
                return new int[0];
            }
            foreach (var item in items)
            {
                result[idx++] = item;
            }

            if (nextGroup.ContainsKey(g))
            {
                foreach (var ng in nextGroup[g].Item1)
                {
                    if (nextGroup[ng].Item2 == 1)
                    {
                        queueGroup.Enqueue(ng);
                    }
                    else
                    {
                        nextGroup[ng] = (nextGroup[ng].Item1, nextGroup[ng].Item2 - 1);
                    }
                }
            }
        }

        return idx == n ? result : new int[0];
    }
}
// @lc code=end

