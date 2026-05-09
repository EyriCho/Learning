/*
 * @lc app=leetcode id=1559 lang=csharp
 *
 * [1559] Detect Cycles in 2D Grid
 */

// @lc code=start
public class Solution {
    public bool ContainsCycle(char[][] grid) {
        int total = grid.Length * grid[0].Length;
        int[] groups = new int[total];
        for (int i = 0; i < total; i++)
        {
            groups[i] = i;
        }

        int FindGroup(int idx)
        {
            return groups[idx] = (groups[idx] == idx ? idx : FindGroup(groups[idx]));
        }

        int groupA = 0,
            groupB = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (i > 0 && grid[i][j] == grid[i - 1][j])
                {
                    groupA = FindGroup(i * grid[0].Length + j);
                    groupB = FindGroup((i - 1) * grid[0].Length + j);
                    if (groupA == groupB)
                    {
                        return true;
                    }

                    groups[groupA] = groupB;
                }

                if (j > 0 && grid[i][j] == grid[i][j - 1])
                {
                    groupA = FindGroup(i * grid[0].Length + j);
                    groupB = FindGroup(i * grid[0].Length + j - 1);
                    if (groupA == groupB)
                    {
                        return true;
                    }

                    groups[groupA] = groupB;
                }
            }
        }

        return false;
    }
}
// @lc code=end

