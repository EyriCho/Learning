/*
 * @lc app=leetcode id=778 lang=csharp
 *
 * [778] Swim in Rising Water
 */

// @lc code=start
public class Solution {
    public int SwimInWater(int[][] grid) {
        int[,] ds = new int[,] {
            { 1, 0 },
            { 0, 1 },
            { -1, 0 },
            { 0, -1 },
        };
        int last = grid.Length - 1;

        bool FindPath(int level)
        {
            HashSet<int> set = new ();
            set.Add(0);
            Stack<int> stack = new ();
            stack.Push(0);
            int x = 0, y = 0, p = 0,
                nx = 0, ny = 0, np = 0;
            
            while (stack.Count > 0)
            {
                p = stack.Pop();
                x = p / grid.Length;
                y = p % grid.Length;

                if (x == last && y == last)
                {
                    return true;
                }

                for (int d = 0; d < 4; d++)
                {
                    nx = x + ds[d, 0];
                    ny = y + ds[d, 1];
                    if (nx < 0 || nx >= grid.Length ||
                        ny < 0 || ny >= grid.Length ||
                        grid[nx][ny] > level)
                    {
                        continue;
                    }
                    np = nx * grid.Length + ny;
                    if (set.Contains(np))
                    {
                        continue;
                    }

                    set.Add(np);
                    stack.Push(np);
                }
            }

            return false;
        }

        int l = grid[0][0],
            r = grid.Length * grid.Length,
            m = 0;

        while (l < r)
        {
            m = (l + r) >> 1;
            if (!FindPath(m))
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l;
    }
}
// @lc code=end

