/*
 * @lc app=leetcode id=1041 lang=csharp
 *
 * [1041] Robot Bounded In Circle
 */

// @lc code=start
public class Solution {
    public bool IsRobotBounded(string instructions) {
        int x = 0, y = 0, direction = 0;
        
        for (int i = 0; i < instructions.Length; i++)
        {
            switch (instructions[i])
            {
                case 'L':
                    direction = (direction + 3) % 4;
                    break;
                case 'R':
                    direction = (direction + 1) % 4;
                    break;
                case 'G':
                    switch (direction)
                    {
                        case 0:
                            y++;
                            break;
                        case 1:
                            x++;
                            break;
                        case 2:
                            y--;
                            break;
                        case 3:
                            x--;
                            break;
                    }
                    break;
            }
        }
        
        if ((x == 0 && y == 0) || direction != 0)
            return true;
        return false;
    }
}
// @lc code=end

