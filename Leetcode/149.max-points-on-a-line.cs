/*
 * @lc app=leetcode id=149 lang=csharp
 *
 * [149] Max Points on a Line
 */

// @lc code=start
public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length < 3)
        {
            return points.Length;
        }

        var result = 1;
        var dict = new Dictionary<double, int>();
        for (int i = 0; i < points.Length; i++)
        {
            dict.Clear();
            int same = 1, vertical = 0;

            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[i][0] == points[j][0] &&
                    points[i][1] == points[j][1])
                {
                    same++;
                }
                else if (points[i][0] == points[j][0])
                {
                    vertical++;
                }
                else
                {
                    var k = ((double)(points[j][1] - points[i][1]) / (points[j][0] - points[i][0]));
                    if (!dict.TryGetValue(k, out int count))
                    {
                        count = 0;
                    }
                    dict[k] = count + 1;
                }
            }
            result = Math.Max(result, vertical + same);
            foreach (var kv in dict)
            {
                result = Math.Max(result, kv.Value + same);
            }
        }
        return result;
    }
}
// @lc code=end

