/*
 * @lc app=leetcode id=3508 lang=csharp
 *
 * [3508] Implement Router
 */

// @lc code=start
public class Router {

    int limit;
    HashSet<(int, int, int)> set;
    Queue<(int, int, int)> queue;
    Dictionary<int, IList<int>> destDict;

    public Router(int memoryLimit) {
        limit = memoryLimit;
        set = new ();
        queue = new ();
        destDict = new ();
    }
    
    public bool AddPacket(int source, int destination, int timestamp) {
        (int, int, int) packet = (source, destination, timestamp);
        if (set.Contains(packet))
        {
            return false;
        }

        if (queue.Count == limit)
        {
            ForwardPacket();
        }

        queue.Enqueue(packet);
        set.Add(packet);
        if (!destDict.TryGetValue(destination, out IList<int> list))
        {
            destDict[destination] = list = new List<int> ();
        }
        list.Add(timestamp);
        return true;
    }
    
    public int[] ForwardPacket() {
        if (queue.Count == 0)
        {
            return new int[0];
        }

        (int, int, int) forward = queue.Dequeue();
        set.Remove(forward);
        destDict.TryGetValue(forward.Item2, out IList<int> list);
        list.RemoveAt(0);
        return new int[] { forward.Item1, forward.Item2, forward.Item3 };
    }
    
    public int GetCount(int destination, int startTime, int endTime) {
        destDict.TryGetValue(destination, out IList<int> list);
        if (list == null || list.Count == 0)
        {
            return 0;
        }

        int Locate(int time)
        {
            int l = 0, m = 0, r = list.Count;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (list[m] < time)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            return l;
        }

        int s = Locate(startTime),
            e = Locate(endTime + 1);

        return e - s;
    }
}

/**
 * Your Router object will be instantiated and called as such:
 * Router obj = new Router(memoryLimit);
 * bool param_1 = obj.AddPacket(source,destination,timestamp);
 * int[] param_2 = obj.ForwardPacket();
 * int param_3 = obj.GetCount(destination,startTime,endTime);
 */
 // @lc code=end

