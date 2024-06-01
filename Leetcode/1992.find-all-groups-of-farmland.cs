/*
 * @lc app=leetcode id=1992 lang=csharp
 *
 * [1992] Find All Groups of Farmland
 */

// @lc code=start
public class Solution {
    public int[][] FindFarmland(int[][] land) {
        List<int[]> list = new();

        void LocateFarm(int t, int l)
        {
            int b = t,
                r = l;

            while (b < land.Length && land[b][l] == 1)
            {
                b++;
            }

            while (r < land[0].Length && land[t][r] == 1)
            {
                r++;
            }

            for (int i = t; i < b; i++)
            {
                for (int j = l; j < r; j++)
                {
                    land[i][j] = -1;
                }
            }

            list.Add(new int[] { t, l, b - 1, r - 1 });
        }

        for (int i = 0; i < land.Length; i++)
        {
            for (int j = 0; j < land[0].Length; j++)
            {
                if (land[i][j] > 0)
                {
                    LocateFarm(i, j);
                }
            }
        }

        return list.ToArray();
    }
}
// @lc code=end

