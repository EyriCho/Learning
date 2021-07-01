/*
 * @lc app=leetcode id=778 lang=csharp
 *
 * [778] Swim in Rising Water
 */

// @lc code=start
public class Solution {
    public int SwimInWater(int[][] grid) {
        var directions = new int[,] 
        {
            { 0, -1 },
            { -1, 0 },
            { 0, 1 },
            { 1, 0 }
        };
        
        bool Search(int level)
        {
            var set = new HashSet<int>();
            set.Add(0);
            var stack = new Stack<int>();
            stack.Push(0);
            while (stack.Count > 0)
            {
                var next = stack.Pop();
                int i = next / grid.Length, j = next % grid.Length;
                if (i == grid.Length - 1 && j == grid.Length - 1)
                    return true;
                for (int k = 0; k < 4; k++)
                {
                    int x = i + directions[k, 0],
                        y = j + directions[k, 1];
                    
                    var n = x * grid.Length + y;
                    if (x < 0 || x >= grid.Length ||
                       y < 0 || y >= grid.Length ||
                       set.Contains(n) ||
                       grid[x][y] > level)
                        continue;
                    set.Add(n);
                    stack.Push(n);
                }
            }
            
            return false;
        }
        
        int l = grid[0][0], r = grid.Length * grid.Length;
        while (l < r)
        {
            var m = (l + r) / 2;
            if (!Search(m))
                l = m + 1;
            else
                r = m;
        }
        
        return l;
    }
}
// @lc code=end

