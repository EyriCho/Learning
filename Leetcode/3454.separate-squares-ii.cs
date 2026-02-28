/*
 * @lc app=leetcode id=3454 lang=csharp
 *
 * [3454] Separate Squares II
 */

// @lc code=start
public class Solution {
    public double SeparateSquares(int[][] squares) {
        int i = 0;
        (int y, int type, int xStart, int xEnd)[] events =
            new (int, int, int, int)[squares.Length * 2];

        foreach (int[] square in squares)
        {
            events[i++] = (square[1], 1, square[0], square[0] + square[2]);
            events[i++] = (square[1] + square[2], -1, square[0], square[0] + square[2]);
        }

        Array.Sort(events, (a, b) => a.y.CompareTo(b.y));

        List<(int s, int e)> xRanges = new ();
        List<(int y, int h, double w)> areas = new ();
        int prevY = events[0].y,
            height = 0;
        double total = 0D,
            width = 0D;

        double UnionWidth()
        {
            xRanges.Sort();
            double rst = 0D;
            int end = 0;
            foreach ((int s, int e) in xRanges)
            {
                if (s >= end)
                {
                    rst += e - s;
                    end = e;
                }
                else if (e > end)
                {
                    rst += e - end;
                    end = e;
                }
            }
            return rst;
        }

        foreach ((int y, int type, int xStart, int xEnd) in events)
        {
            if (y > prevY && xRanges.Count > 0)
            {
                height = y - prevY;
                width = UnionWidth();
                areas.Add((prevY, height, width));
                total += height * width;
            }

            if (type == 1)
            {
                xRanges.Add((xStart, xEnd));
            }
            else
            {
                xRanges.Remove((xStart, xEnd));
            }

            prevY = y;
        }

        double target = total / 2D,
            sum = 0D;

        foreach ((int y, int h, double w) in areas)
        {
            if (h * w + sum >= target)
            {
                return y + (target - sum) / w;
            }

            sum += h * w;
        }

        return 0D;
    }
}
// @lc code=end

