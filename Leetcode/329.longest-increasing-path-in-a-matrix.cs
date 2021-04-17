/*
 * @lc app=leetcode id=329 lang=csharp
 *
 * [329] Longest Increasing Path in a Matrix
 */

// @lc code=start
public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        int[,] steps = new int[matrix.Length, matrix[0].Length];
        
        int[][] directions = new int[][] {
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
        };
        int result = 0;
        
        void dfs(int x, int y, int step)
        {
            steps[x, y] = Math.Max(steps[x, y], step);
            result = Math.Max(steps[x, y], result);
            
            int s = step + 1;
            foreach (var d in directions)
            {
                int i = x + d[0],
                    j = y + d[1];
                
                if (i > -1 && i < matrix.Length &&
                   j > -1 && j < matrix[0].Length &&
                   matrix[i][j] > matrix[x][y] &&
                   steps[i, j] < s)
                    dfs(i, j, s);
            }
        }
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
                dfs(i, j, 1);
        
        return result;
    }
}
// @lc code=end

