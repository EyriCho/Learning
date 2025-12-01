/*
 * @lc app=leetcode id=1488 lang=csharp
 *
 * [1488] Avoid Flood in The City
 */

// @lc code=start
public class Solution {
    public int[] AvoidFlood(int[] rains) {
        List<int> drys = new ();
        Dictionary<int, int> fulls = new ();

        int Locate(int d)
        {
            int l = 0, r = drys.Count,
                m = 0;
            
            while (l < r)
            {
                m = (l + r) >> 1;
                if (drys[m] <= d)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            return l == drys.Count ? -1 : l;
        }

        int[] result = new int[rains.Length];
        int dry = 0;
        for (int i = 0; i < rains.Length; i++)
        {
            if (rains[i] == 0)
            {
                result[i] = 1;
                drys.Add(i);
                continue;
            }

            result[i] = -1;
            if (fulls.TryGetValue(rains[i], out int day))
            {
                dry = Locate(day);
                if (dry == -1)
                {
                    return new int[0];
                }

                result[drys[dry]] = rains[i];
                drys.RemoveAt(dry);
            }
            fulls[rains[i]] = i;
        }

        return result;
    }
}
// @lc code=end

