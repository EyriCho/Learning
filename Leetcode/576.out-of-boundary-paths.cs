/*
 * @lc app=leetcode id=576 lang=csharp
 *
 * [576] Out of Boundary Paths
 */

// @lc code=start
public class Solution {
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        if (maxMove == 0)
            return 0;
        
        var directions = new int[,] {
            { -1, 0 },
            { 0, -1 },
            { 1, 0 },
            { 0, 1 },
        };
        
        var prev = new int[m, n];
        var current = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            current[i, 0]++;
            current[i, n - 1]++;
        }
        for (int i = 0; i < n; i++)
        {
            current[0, i]++;
            current[m - 1, i]++;
        }
        
        int round = 0,
            result = 0;
        while (round++ < maxMove)
        {
            result = (current[startRow, startColumn] + result) % 1_000_000_007;
            var temp = prev;
            prev = current;
            current = temp;
            
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    current[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        int x = i + directions[k, 0],
                            y = j + directions[k, 1];
                        
                        if (x >= 0 && x < m &&
                           y >= 0 && y < n)
                            current[i, j] = (current[i, j] + prev[x, y]) % 1_000_000_007;
                    }
                }
        }
        
        return result;
    }
}
// @lc code=end

