/*
 * @lc app=leetcode id=478 lang=csharp
 *
 * [478] Generate Random Point in a Circle
 */

// @lc code=start
public class Solution {

    public Solution(double radius, double x_center, double y_center) {
        rand = new Random();
        r = radius;
        x = x_center;
        y = y_center;
    }
    Random rand;
    double r;
    double x;
    double y;
    
   
    public double[] RandPoint() {
        double radius = Math.Sqrt(rand.NextDouble()) * r;
        double angle = rand.NextDouble() * Math.PI * 2;
        
        return new double[] {
            x + radius * Math.Cos(angle),
            y + radius * Math.Sin(angle)
        };
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(radius, x_center, y_center);
 * double[] param_1 = obj.RandPoint();
 */
// @lc code=end

