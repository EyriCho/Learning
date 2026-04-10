/*
 * @lc app=leetcode id=2069 lang=csharp
 *
 * [2069] Walking Robot Simulation II
 */

// @lc code=start
public class Robot {

    private int total;
    private int steps;
    private (int[] p, string dir)[] pos;

    public Robot(int width, int height) {
        int w = width - 1,
            h = height - 1;
        total = (w + h) << 1;
        steps = 0;

        pos = new (int[], string)[total];
        int k = 1;
        for (int i = 1; i < width; i++)
        {
            pos[k++] = (new int[] { i, 0 }, "East");
        }
        for (int j = 1; j < height; j++)
        {
            pos[k++] = (new int[] { w, j }, "North");
        }
        for (int i = w - 1; i >= 0; i--)
        {
            pos[k++] = (new int[] { i, h }, "West");
        }
        for (int j = h - 1; j > 0; j--)
        {
            pos[k++] = (new int[] { 0, j }, "South");
        }
        pos[0] = (new int[] { 0, 0 }, "South");
    }
    
    public void Step(int num) {
        steps += num;
    }
    
    public int[] GetPos() {
        return pos[steps % total].p;
    }
    
    public string GetDir() {
        return steps == 0 ? "East" : pos[steps % total].dir;    
    }
}

/**
 * Your Robot object will be instantiated and called as such:
 * Robot obj = new Robot(width, height);
 * obj.Step(num);
 * int[] param_2 = obj.GetPos();
 * string param_3 = obj.GetDir();
 */
// @lc code=end

