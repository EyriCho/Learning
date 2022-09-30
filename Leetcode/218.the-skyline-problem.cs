/*
 * @lc app=leetcode id=218 lang=csharp
 *
 * [218] The Skyline Problem
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings) {
        var result = new List<IList<int>>();
        if (buildings.Length == 0)
        {
            return result;
        }
        
        int h = 0, x = 0, i = 0;
        SortedSet<(int, int)> queue = new SortedSet<(int, int)>(
            Comparer<(int, int)>.Create((l, r) => {
                if (l.Item1 == r.Item1)
                {
                    return r.Item2 - l.Item2;
                }
                else
                {
                    return r.Item1 - l.Item1;
                }
            })
        );
        while (i < buildings.Length || queue.Count > 0)
        {
            x = queue.Count == 0 ? buildings[i][0] : queue.First().Item2;
            if (i >= buildings.Length || buildings[i][0] > x)
            {
                while (queue.Count > 0 && queue.First().Item2 <= x)
                {
                    queue.Remove(queue.First());
                }
            }
            else
            {
                x = buildings[i][0];
                while (i < buildings.Length && buildings[i][0] == x)
                {
                    if (!queue.Contains((buildings[i][2], buildings[i][1])))
                    {
                        queue.Add((buildings[i][2], buildings[i][1]));
                    }
                    i++;
                }
            }
            h = queue.Count > 0 ? queue.First().Item1 : 0;
            if (result.Count == 0 || result[result.Count - 1][1] != h)
            {
                result.Add(new List<int>() { x, h });
            }
        }
        
        return result;
    }
}
// @lc code=end

