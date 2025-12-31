/*
 * @lc app=leetcode id=3625 lang=csharp
 *
 * [3625] Count Number of Trapezoids II
 */

// @lc code=start
public class Solution {
    public int CountTrapezoids(int[][] points) {
        int Gcd(int a, int b)
        {
            int temp = 0;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        Dictionary<(int, int), Dictionary<int, int>> slopeDict = new ();
        Dictionary<(int, int), Dictionary<(int, int), int>> midDict = new ();

        int dx = 0, dy = 0,
            intersect = 0,
            g = 0,
            mx = 0, my = 0,
            count = 0;
        Dictionary<int, int> slopeIntersectDict = null;
        Dictionary<(int, int), int> midSlopeDict = null;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                dx = points[j][0] - points[i][0];
                dy = points[j][1] - points[i][1];
                g = Gcd(Math.Abs(dx), Math.Abs(dy));
                dx /= g;
                dy /= g;

                if (dx < 0 || (dx == 0 && dy < 0))
                {
                    dx = -dx;
                    dy = -dy;
                }
                intersect = points[i][1] * dx - points[i][0] * dy;
                if (!slopeDict.TryGetValue((dx, dy), out slopeIntersectDict))
                {
                    slopeDict[(dx, dy)] = slopeIntersectDict = new ();
                }
                slopeIntersectDict.TryGetValue(intersect, out count);
                slopeIntersectDict[intersect] = count + 1;

                mx = points[i][0] + points[j][0];
                my = points[i][1] + points[j][1];
                if (!midDict.TryGetValue((mx, my), out midSlopeDict))
                {
                    midDict[(mx, my)] = midSlopeDict = new ();
                }
                midSlopeDict.TryGetValue((dx, dy), out count);
                midSlopeDict[(dx, dy)] = count + 1;
            }
        }

        int result = 0,
            sum = 0;
        foreach (Dictionary<int, int> intersectDict in slopeDict.Values)
        {
            if (intersectDict.Count == 1)
            {
                continue;
            }
            sum = 0;
            foreach (int c in intersectDict.Values)
            {
                result += sum * c;
                sum += c;
            }
        }

        foreach (Dictionary<(int, int), int> slopes in midDict.Values)
        {
            if (slopes.Count == 1)
            {
                continue;
            }

            sum = 0;
            foreach (int c in slopes.Values)
            {
                result -= sum * c;
                sum += c;
            }
        }

        return result;
    }
}
// @lc code=end

