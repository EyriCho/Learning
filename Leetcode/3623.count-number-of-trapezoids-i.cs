/*
 * @lc app=leetcode id=3623 lang=csharp
 *
 * [3623] Count Number of Trapezoids I
 */

// @lc code=start
public class Solution {
    public int CountTrapezoids(int[][] points) {
        Dictionary<int, int> horizontals = new ();

        int count = 0;
        foreach (int[] point in points)
        {
            horizontals.TryGetValue(point[1], out count);
            horizontals[point[1]] = count + 1;
        }

        long result = 0L,
            sum = 0L,
            edges = 0L;
        foreach (KeyValuePair<int, int> kv in horizontals)
        {
            edges = ((long)kv.Value * (kv.Value - 1) >> 1);
            result = (result + sum * edges) % 1_000_000_007L;
            sum += edges;
        }

        return (int)result;
    }
}
// @lc code=end

