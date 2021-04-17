/*
 * @lc app=leetcode id=417 lang=csharp
 *
 * [417] Pacific Atlantic Water Flow
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        var result = new List<IList<int>>();
        if (matrix.Length == 0)
            return result;
        if (matrix[0].Length == 0)
            return result;
        
        bool[,] p_reach = new bool[matrix.Length, matrix[0].Length];
        bool[,] a_reach = new bool[matrix.Length, matrix[0].Length];
        
        int lastX = matrix.Length - 1,
            lastY = matrix[0].Length - 1;
        int[,] directions = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 }
        };
        
        void dfs(bool[,] r, int x, int y)
        {
            r[x, y] = true;
            for (int i = 0; i < 4; i++)
            {
                int nextX = x + directions[i, 0],
                    nextY = y + directions[i, 1];
                
                if (nextX > -1 && nextX < matrix.Length &&
                   nextY > -1 && nextY < matrix[0].Length &&
                   !r[nextX, nextY] && matrix[x][y] <= matrix[nextX][nextY])
                    dfs(r, nextX, nextY);
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            dfs(p_reach, i, 0);
            dfs(a_reach, i, lastY);
        }
        for (int i = 0; i < matrix[0].Length; i++)
        {
            dfs(p_reach, 0, i);
            dfs(a_reach, lastX, i);
        }
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
                if (a_reach[i, j] && p_reach[i, j])
                    result.Add(new List<int> { i, j });
        
        return result;
    }
}
// @lc code=end

