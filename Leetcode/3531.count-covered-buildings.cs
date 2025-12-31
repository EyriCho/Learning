/*
 * @lc app=leetcode id=3531 lang=csharp
 *
 * [3531] Count Covered Buildings
 */

// @lc code=start
public class Solution {
    public int CountCoveredBuildings(int n, int[][] buildings) {
        int[] minRow = new int[n + 1],
            maxRow = new int[n + 1],
            minCol = new int[n + 1],
            maxCol = new int[n + 1];
        
        Array.Fill(minRow, n + 1);
        Array.Fill(minCol, n + 1);

        foreach (int[] b in buildings)
        {
            minRow[b[1]] = Math.Min(b[0], minRow[b[1]]);
            maxRow[b[1]] = Math.Max(b[0], maxRow[b[1]]);
            minCol[b[0]] = Math.Min(b[1], minCol[b[0]]);
            maxCol[b[0]] = Math.Max(b[1], maxCol[b[0]]);
        }

        int result = 0;
        foreach (int[] b in buildings)
        {
            if (b[0] == minRow[b[1]] ||
                b[0] == maxRow[b[1]] ||
                b[1] == minCol[b[0]] ||
                b[1] == maxCol[b[0]])
            {
                continue;
            }

            result++;
        }

        return result;
    }
}
// @lc code=end

