/*
 * @lc app=leetcode id=417 lang=csharp
 *
 * [417] Pacific Atlantic Water Flow
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        List<IList<int>> result = new ();

        int[,] ds = new int[,] {
            { 1, 0 },
            { 0, 1 },
            { -1, 0 },
            { 0, -1 },
        };

        bool[,] pReach = new bool[heights.Length, heights[0].Length],
            aReach = new bool[heights.Length, heights[0].Length];
        
        void Dfs(int x, int y, bool[,] reach)
        {
            reach[x, y] = true;

            int i = 0,
                j = 0;
            
            for (int d = 0; d < 4; d++)
            {
                i = x + ds[d, 0];
                j = y + ds[d, 1];

                if (i < 0 || i >= heights.Length ||
                    j < 0 || j >= heights[0].Length ||
                    reach[i, j] ||
                    heights[i][j] < heights[x][y])
                {
                    continue;
                }

                Dfs(i, j, reach);
            }
        }

        for (int i = 0; i < heights.Length; i++)
        {
            Dfs(i, 0, pReach);

            Dfs(i, heights[0].Length - 1, aReach);
        }

        for (int j = 0; j < heights[0].Length; j++)
        {
            Dfs(0, j, pReach);

            Dfs(heights.Length - 1, j, aReach);
        }

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = 0; j < heights[0].Length; j++)
            {
                if (pReach[i, j] && aReach[i, j])
                {
                    result.Add(new List<int> { i, j });
                }
            }
        }

        return result;
    }
}
// @lc code=end

