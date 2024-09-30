/*
 * @lc app=leetcode id=874 lang=csharp
 *
 * [874] Walking Robot Simulation
 */

// @lc code=start
public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        HashSet<(int, int)> set = new ();
        foreach (int[] obstacle in obstacles)
        {
            set.Add((obstacle[0], obstacle[1]));
        }

        int[,] directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int d = 0,
            x = 0,
            y = 0,
            result = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == -1)
            {
                d += 1;
                d %= 4;
            }
            else if (commands[i] == -2)
            {
                d -= 1;
                if (d < 0)
                {
                    d = 3;
                }
            }
            else
            {
                while (commands[i]-- > 0 &&
                    !set.Contains((x + directions[d, 0], y + directions[d, 1])))
                {
                    x += directions[d, 0];
                    y += directions[d, 1];
                }
            }

            result = Math.Max(result, x * x + y * y);
        }

        return result;
    }
}
// @lc code=end

