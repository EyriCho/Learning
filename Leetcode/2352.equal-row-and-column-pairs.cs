/*
 * @lc app=leetcode id=2352 lang=csharp
 *
 * [2352] Equal Row and Column Pairs
 */

// @lc code=start
public class Solution {
    public int EqualPairs(int[][] grid) {
        var hashes = new Dictionary<int, int>();

        for (int i = 0; i < grid.Length; i++)
        {
            var hash = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                hash = HashCode.Combine(hash, grid[i][j]);
            }
            hashes.TryGetValue(hash, out int c);
            hashes[hash] = c + 1;
        }

        var result = 0;
        for (int j = 0; j < grid.Length; j++)
        {
            var hash = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                hash = HashCode.Combine(hash, grid[i][j]);
            }
            hashes.TryGetValue(hash, out int c);
            result += c;
        }

        return result;
    }
}
// @lc code=end

