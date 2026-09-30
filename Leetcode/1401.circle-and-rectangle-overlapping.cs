/*
 * @lc app=leetcode id=1401 lang=csharp
 *
 * [1401] Circle and Rectangle Overlapping
 */

// @lc code=start
public class Solution {
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2) {
        if (x1 <= xCenter && xCenter <= x2 &&
            y1 <= yCenter && yCenter <= y2)
        {
            return true;
        }

        if (x1 <= xCenter && xCenter <= x2 &&
            y2 <= yCenter && yCenter <= y2 + radius)
        {
// Console.WriteLine($"Above");
            return true;
        }

        if (x1 <= xCenter && xCenter <= x2 &&
            yCenter <= y1 && y1 <= yCenter + radius)
        {
// Console.WriteLine($"Below");
            return true;
        }

        if (y1 <= yCenter && yCenter <= y2 &&
            x2 <= xCenter && xCenter <= x2 + radius)
        {
// Console.WriteLine($"Right");
            return true;
        }

        if (y1 <= yCenter && yCenter <= y2 &&
            xCenter <= x1 && x1 <= xCenter + radius)
        {
// Console.WriteLine($"Left");
            return true;
        }

        long Distance(int ux, int uy, int vx, int vy)
        {
            return (long)(ux - vx) * (ux - vx) + (long)(uy - vy) * (uy - vy);
        }

        int rSqrt = radius * radius;

        if (Distance(x1, y1, xCenter, yCenter) <= rSqrt)
        {
// Console.WriteLine($"Bottom Left");
            return true;
        }

        if (Distance(x1, y2, xCenter, yCenter) <= rSqrt)
        {
// Console.WriteLine($"Top Left");
            return true;
        }

        if (Distance(x2, y1, xCenter, yCenter) <= rSqrt)
        {
// Console.WriteLine($"Bottom right");
            return true;
        }

        if (Distance(x2, y2, xCenter, yCenter) <= rSqrt)
        {
// Console.WriteLine($"Top Right");
            return true;
        }

        return false;
    }
}
// @lc code=end

