/*
 * @lc app=leetcode id=1496 lang=csharp
 *
 * [1496] Path Crossing
 */

// @lc code=start
public class Solution {
    public bool IsPathCrossing(string path) {
        HashSet<(int, int)> set = new();
        set.Add((0, 0));

        int x = 0,
            y = 0;

        foreach (char d in path)
        {
            if (d == 'N')
            {
                x--;
            }
            else if (d == 'S')
            {
                x++;
            }
            else if (d == 'E')
            {
                y++;
            }
            else if (d == 'W')
            {
                y--;
            }
            
            if (set.Contains((x, y)))
            {
                return true;
            }
            set.Add((x, y));
        }

        return false;
    }
}
// @lc code=end

