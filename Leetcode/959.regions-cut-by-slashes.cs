/*
 * @lc app=leetcode id=959 lang=csharp
 *
 * [959] Regions Cut By Slashes
 */

// @lc code=start
public class Solution {
    public int RegionsBySlashes(string[] grid) {
        int count = grid.Length * grid.Length * 4;
        int[] groups = new int[count];
        for (int i = 0; i < count; i++)
        {
            groups[i] = i;
        }

        int Find(int index)
        {
            if (groups[index] != index)
            {
                return groups[index] = Find(groups[index]);
            }

            return index;
        }

        void Union(int group1, int group2)
        {
            if (group1 != group2)
            {
                groups[group2] = group1;
                count--;
            }
        }

        int t = 0, b = 0,
            l = 0, r = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                t = (i * grid.Length + j) * 4;
                r = (i * grid.Length + j) * 4 + 1;
                b = (i * grid.Length + j) * 4 + 2;
                l = (i * grid.Length + j) * 4 + 3;
                if (i > 0)
                {
                    Union(Find(((i - 1) * grid.Length + j) * 4 + 2),
                        Find(t));
                }

                if (j > 0)
                {
                    Union(Find((i * grid.Length + j - 1) * 4 + 1),
                        Find(l));
                }

                if (grid[i][j] != '/')
                {
                    Union(Find(t),
                        Find(r));

                    Union(Find(b),
                        Find(l));
                }

                if (grid[i][j] != '\\')
                {
                    Union(Find(t),
                        Find(l));

                    Union(Find(r),
                        Find(b));
                }
            }
        }
        
        return count;
    }
}
// @lc code=end

